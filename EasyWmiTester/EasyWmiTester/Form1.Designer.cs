namespace EasyWmiTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunWmiButton = new System.Windows.Forms.Button();
            this.WmiQueryTextBox = new System.Windows.Forms.TextBox();
            this.SubKeyNameTextBox = new System.Windows.Forms.TextBox();
            this.RunRegQueryButton = new System.Windows.Forms.Button();
            this.ValueNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WmiQueryResultsListBox = new System.Windows.Forms.ListBox();
            this.ExampleQueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WmiRegQueryResultsListBox = new System.Windows.Forms.ListBox();
            this.LoadExampleRegQueryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunWmiButton
            // 
            this.RunWmiButton.Location = new System.Drawing.Point(365, 81);
            this.RunWmiButton.Name = "RunWmiButton";
            this.RunWmiButton.Size = new System.Drawing.Size(75, 40);
            this.RunWmiButton.TabIndex = 0;
            this.RunWmiButton.Text = "Run WMI query";
            this.RunWmiButton.UseVisualStyleBackColor = true;
            this.RunWmiButton.Click += new System.EventHandler(this.RunWmiButton_Click);
            // 
            // WmiQueryTextBox
            // 
            this.WmiQueryTextBox.Location = new System.Drawing.Point(110, 28);
            this.WmiQueryTextBox.Name = "WmiQueryTextBox";
            this.WmiQueryTextBox.Size = new System.Drawing.Size(598, 20);
            this.WmiQueryTextBox.TabIndex = 2;
            // 
            // SubKeyNameTextBox
            // 
            this.SubKeyNameTextBox.Location = new System.Drawing.Point(112, 12);
            this.SubKeyNameTextBox.Name = "SubKeyNameTextBox";
            this.SubKeyNameTextBox.Size = new System.Drawing.Size(583, 20);
            this.SubKeyNameTextBox.TabIndex = 3;
            // 
            // RunRegQueryButton
            // 
            this.RunRegQueryButton.Location = new System.Drawing.Point(365, 85);
            this.RunRegQueryButton.Name = "RunRegQueryButton";
            this.RunRegQueryButton.Size = new System.Drawing.Size(75, 40);
            this.RunRegQueryButton.TabIndex = 4;
            this.RunRegQueryButton.Text = "Run Reg query";
            this.RunRegQueryButton.UseVisualStyleBackColor = true;
            this.RunRegQueryButton.Click += new System.EventHandler(this.RunRegQueryButton_Click);
            // 
            // ValueNameTextBox
            // 
            this.ValueNameTextBox.Location = new System.Drawing.Point(112, 38);
            this.ValueNameTextBox.Name = "ValueNameTextBox";
            this.ValueNameTextBox.Size = new System.Drawing.Size(583, 20);
            this.ValueNameTextBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 428);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WmiQueryResultsListBox);
            this.tabPage1.Controls.Add(this.ExampleQueryButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.WmiQueryTextBox);
            this.tabPage1.Controls.Add(this.RunWmiButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WMI Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WmiQueryResultsListBox
            // 
            this.WmiQueryResultsListBox.FormattingEnabled = true;
            this.WmiQueryResultsListBox.HorizontalScrollbar = true;
            this.WmiQueryResultsListBox.Location = new System.Drawing.Point(3, 158);
            this.WmiQueryResultsListBox.Name = "WmiQueryResultsListBox";
            this.WmiQueryResultsListBox.Size = new System.Drawing.Size(705, 238);
            this.WmiQueryResultsListBox.TabIndex = 5;
            // 
            // ExampleQueryButton
            // 
            this.ExampleQueryButton.Location = new System.Drawing.Point(275, 81);
            this.ExampleQueryButton.Name = "ExampleQueryButton";
            this.ExampleQueryButton.Size = new System.Drawing.Size(84, 40);
            this.ExampleQueryButton.TabIndex = 4;
            this.ExampleQueryButton.Text = "Load Example Query";
            this.ExampleQueryButton.UseVisualStyleBackColor = true;
            this.ExampleQueryButton.Click += new System.EventHandler(this.ExampleQueryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WMI Query: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WmiRegQueryResultsListBox);
            this.tabPage2.Controls.Add(this.LoadExampleRegQueryButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RunRegQueryButton);
            this.tabPage2.Controls.Add(this.SubKeyNameTextBox);
            this.tabPage2.Controls.Add(this.ValueNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WMI Reg Query";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WmiRegQueryResultsListBox
            // 
            this.WmiRegQueryResultsListBox.FormattingEnabled = true;
            this.WmiRegQueryResultsListBox.HorizontalScrollbar = true;
            this.WmiRegQueryResultsListBox.Location = new System.Drawing.Point(3, 158);
            this.WmiRegQueryResultsListBox.Name = "WmiRegQueryResultsListBox";
            this.WmiRegQueryResultsListBox.Size = new System.Drawing.Size(705, 238);
            this.WmiRegQueryResultsListBox.TabIndex = 11;
            // 
            // LoadExampleRegQueryButton
            // 
            this.LoadExampleRegQueryButton.Location = new System.Drawing.Point(275, 85);
            this.LoadExampleRegQueryButton.Name = "LoadExampleRegQueryButton";
            this.LoadExampleRegQueryButton.Size = new System.Drawing.Size(84, 40);
            this.LoadExampleRegQueryButton.TabIndex = 10;
            this.LoadExampleRegQueryButton.Text = "Load Example Query";
            this.LoadExampleRegQueryButton.UseVisualStyleBackColor = true;
            this.LoadExampleRegQueryButton.Click += new System.EventHandler(this.LoadExampleRegQueryButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "sValueName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "sSubKeyName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "EasyWMI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunWmiButton;
        private System.Windows.Forms.TextBox WmiQueryTextBox;
        private System.Windows.Forms.TextBox SubKeyNameTextBox;
        private System.Windows.Forms.Button RunRegQueryButton;
        private System.Windows.Forms.TextBox ValueNameTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExampleQueryButton;
        private System.Windows.Forms.Button LoadExampleRegQueryButton;
        private System.Windows.Forms.ListBox WmiQueryResultsListBox;
        private System.Windows.Forms.ListBox WmiRegQueryResultsListBox;
    }
}

