﻿using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace EasyWmiTester
{
    public partial class Form1 : Form
    {
        #region Constants

        private const string WMI_QUERY_EXAMPLE = "SELECT * FROM Win32_LogicalDisk";
        private const string SUB_KEY_NAME_EXAMPLE = "SOFTWARE\\Microsoft\\.NETFramework";
        private const string VALUE_NAME_EXAMPLE = "InstallRoot";

        #endregion Constants

        #region Enums

        public enum RegHive : uint
        {
            HKEY_CLASSES_ROOT = 0x80000000,
            HKEY_CURRENT_USER = 0x80000001,
            HKEY_LOCAL_MACHINE = 0x80000002,
            HKEY_USERS = 0x80000003,
            HKEY_CURRENT_CONFIG = 0x80000005
        }

        public enum RegType
        {
            REG_SZ = 1,
            REG_EXPAND_SZ,
            REG_BINARY,
            REG_DWORD,
            REG_MULTI_SZ = 7
        }

        #endregion Enums

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Private Helpers

        private List<string> RunWMIQuery(string query)
        {
            List<string> list = new List<string>();

            string scope = @"\\.\root\CIMV2";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            try
            {
                ManagementObjectCollection collection = searcher.Get();

                if (collection.Count == 0)
                {
                    MessageBox.Show("No results from query.");
                }

                foreach (ManagementObject mobj in collection)
                {
                    foreach (PropertyData mobjProp in mobj.Properties)
                    {
                        list.Add(mobjProp.Name + " : " + mobjProp.Value);
                    }

                    list.Add(string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return list;
        }

        private string RunRegWMIQuery(string sSubKeyName, string sValueName)
        {
            try
            {
                ConnectionOptions oConn = new ConnectionOptions();
                oConn.Impersonation = ImpersonationLevel.Impersonate;
                oConn.EnablePrivileges = true;
                oConn.Username = null;
                oConn.Password = null;

                string scopeString = @"\\.\root\default";

                ManagementScope scope = new ManagementScope(scopeString, oConn);
                ManagementPath myPath = new ManagementPath("StdRegProv");
                ManagementClass registry = new ManagementClass(scope, myPath, null);

                object oValue = GetValue(registry, RegHive.HKEY_LOCAL_MACHINE, sSubKeyName, sValueName);
                return oValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "";
        }

        private static object GetValue(ManagementClass mc, RegHive hDefKey, string sSubKeyName, string sValueName)
        {
            RegType rType = GetValueType(mc, hDefKey, sSubKeyName, sValueName);

            ManagementBaseObject inParams = mc.GetMethodParameters("GetStringValue");
            inParams["hDefKey"] = hDefKey;
            inParams["sSubKeyName"] = sSubKeyName;
            inParams["sValueName"] = sValueName;

            object oValue = null;

            switch (rType)
            {
                case RegType.REG_SZ:
                    ManagementBaseObject outParams = mc.InvokeMethod("GetStringValue", inParams, null);

                    if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
                    {
                        oValue = outParams["sValue"];
                    }
                    else
                    {
                        // GetStringValue call failed
                    }
                    break;

                case RegType.REG_EXPAND_SZ:
                    outParams = mc.InvokeMethod("GetExpandedStringValue", inParams, null);

                    if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
                    {
                        oValue = outParams["sValue"];
                    }
                    else
                    {
                        // GetExpandedStringValue call failed
                    }
                    break;

                case RegType.REG_MULTI_SZ:
                    outParams = mc.InvokeMethod("GetMultiStringValue", inParams, null);

                    if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
                    {
                        oValue = outParams["sValue"];
                    }
                    else
                    {
                        // GetMultiStringValue call failed
                    }
                    break;

                case RegType.REG_DWORD:
                    outParams = mc.InvokeMethod("GetDWORDValue", inParams, null);

                    if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
                    {
                        oValue = outParams["uValue"];
                    }
                    else
                    {
                        // GetDWORDValue call failed
                    }
                    break;

                case RegType.REG_BINARY:
                    outParams = mc.InvokeMethod("GetBinaryValue", inParams, null);

                    if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
                    {
                        oValue = outParams["uValue"] as byte[];
                    }
                    else
                    {
                        // GetBinaryValue call failed
                    }
                    break;
            }

            return oValue;
        }

        public static RegType GetValueType(ManagementClass mc, RegHive hDefKey, string sSubKeyName, string sValueName)
        {
            ManagementBaseObject inParams = mc.GetMethodParameters("EnumValues");
            inParams["hDefKey"] = hDefKey;
            inParams["sSubKeyName"] = sSubKeyName;

            ManagementBaseObject outParams = mc.InvokeMethod("EnumValues", inParams, null);

            if (Convert.ToUInt32(outParams["ReturnValue"]) == 0)
            {
                string[] sNames = outParams["sNames"] as String[];
                int[] iTypes = outParams["Types"] as int[];

                for (int i = 0; i < sNames.Length; i++)
                {
                    if (sNames[i] == sValueName)
                    {
                        return (RegType)iTypes[i];
                    }
                }
                // value not found
            }
            else
            {
                // EnumValues call failed
            }

            throw new Exception("no return value");
        }

        #endregion Private Helpers

        #region Event Handlers

        private void RunWmiButton_Click(object sender, EventArgs e)
        {
            WmiQueryResultsListBox.DataSource = null;
            WmiQueryResultsListBox.Refresh();

            WmiQueryResultsListBox.DataSource = RunWMIQuery(WmiQueryTextBox.Text);
            WmiQueryResultsListBox.Refresh();
        }

        private void RunRegQueryButton_Click(object sender, EventArgs e)
        {
            WmiRegQueryResultsListBox.DataSource = null;
            WmiRegQueryResultsListBox.Refresh();

            List<string> list = new List<string>();
            list.Add(RunRegWMIQuery(SubKeyNameTextBox.Text, ValueNameTextBox.Text));

            WmiRegQueryResultsListBox.DataSource = list;
            WmiRegQueryResultsListBox.Refresh();
        }

        private void ExampleQueryButton_Click(object sender, EventArgs e)
        {
            WmiQueryTextBox.Text = WMI_QUERY_EXAMPLE;
        }

        private void LoadExampleRegQueryButton_Click(object sender, EventArgs e)
        {
            SubKeyNameTextBox.Text = SUB_KEY_NAME_EXAMPLE;
            ValueNameTextBox.Text = VALUE_NAME_EXAMPLE;
        }

        #endregion Event Handlers
    }
}