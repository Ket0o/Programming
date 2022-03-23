namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Enums_tabPage = new System.Windows.Forms.TabPage();
            this.SeasonNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Classes_TabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.Length_label = new System.Windows.Forms.Label();
            this.Length_textbox = new System.Windows.Forms.TextBox();
            this.Width_label = new System.Windows.Forms.Label();
            this.Width_textbox = new System.Windows.Forms.TextBox();
            this.Color_label = new System.Windows.Forms.Label();
            this.Color_textbox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Enums_tabPage.SuspendLayout();
            this.SeasonNamesGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Classes_TabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums_tabPage);
            this.tabControl1.Controls.Add(this.Classes_TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 679);
            this.tabControl1.TabIndex = 0;
            // 
            // Enums_tabPage
            // 
            this.Enums_tabPage.Controls.Add(this.SeasonNamesGroupBox);
            this.Enums_tabPage.Controls.Add(this.groupBox2);
            this.Enums_tabPage.Controls.Add(this.groupBox1);
            this.Enums_tabPage.Location = new System.Drawing.Point(4, 29);
            this.Enums_tabPage.Name = "Enums_tabPage";
            this.Enums_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Enums_tabPage.Size = new System.Drawing.Size(1014, 646);
            this.Enums_tabPage.TabIndex = 0;
            this.Enums_tabPage.Text = "Enums";
            this.Enums_tabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonNamesGroupBox
            // 
            this.SeasonNamesGroupBox.Controls.Add(this.GoButton);
            this.SeasonNamesGroupBox.Controls.Add(this.SeasonNamesComboBox);
            this.SeasonNamesGroupBox.Controls.Add(this.label6);
            this.SeasonNamesGroupBox.Location = new System.Drawing.Point(496, 418);
            this.SeasonNamesGroupBox.Name = "SeasonNamesGroupBox";
            this.SeasonNamesGroupBox.Size = new System.Drawing.Size(518, 215);
            this.SeasonNamesGroupBox.TabIndex = 2;
            this.SeasonNamesGroupBox.TabStop = false;
            this.SeasonNamesGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(337, 55);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(112, 30);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(6, 57);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(323, 28);
            this.SeasonNamesComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose season:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputWeekdayLabel);
            this.groupBox2.Controls.Add(this.ParseWeekdayButton);
            this.groupBox2.Controls.Add(this.WeekdayTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(8, 89);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 20);
            this.OutputWeekdayLabel.TabIndex = 3;
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(337, 55);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(112, 29);
            this.ParseWeekdayButton.TabIndex = 2;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(6, 55);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(325, 26);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntValueTextBox);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(520, 55);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(225, 26);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(262, 55);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(225, 264);
            this.ValuesListBox.TabIndex = 4;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(8, 55);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(225, 264);
            this.EnumsListBox.TabIndex = 3;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumeration:";
            // 
            // Classes_TabPage
            // 
            this.Classes_TabPage.Controls.Add(this.groupBox3);
            this.Classes_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Classes_TabPage.Name = "Classes_TabPage";
            this.Classes_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Classes_TabPage.Size = new System.Drawing.Size(1014, 646);
            this.Classes_TabPage.TabIndex = 1;
            this.Classes_TabPage.Text = "Classes";
            this.Classes_TabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FindButton);
            this.groupBox3.Controls.Add(this.Width_textbox);
            this.groupBox3.Controls.Add(this.Color_textbox);
            this.groupBox3.Controls.Add(this.Color_label);
            this.groupBox3.Controls.Add(this.Width_label);
            this.groupBox3.Controls.Add(this.Length_textbox);
            this.groupBox3.Controls.Add(this.Length_label);
            this.groupBox3.Controls.Add(this.RectanglesListBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 313);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 25);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(200, 264);
            this.RectanglesListBox.TabIndex = 0;
            // 
            // Length_label
            // 
            this.Length_label.AutoSize = true;
            this.Length_label.Location = new System.Drawing.Point(212, 25);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(63, 20);
            this.Length_label.TabIndex = 1;
            this.Length_label.Text = "Length:";
            // 
            // Length_textbox
            // 
            this.Length_textbox.Location = new System.Drawing.Point(216, 48);
            this.Length_textbox.Name = "Length_textbox";
            this.Length_textbox.Size = new System.Drawing.Size(146, 26);
            this.Length_textbox.TabIndex = 2;
            // 
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(212, 86);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(54, 20);
            this.Width_label.TabIndex = 3;
            this.Width_label.Text = "Width:";
            // 
            // Width_textbox
            // 
            this.Width_textbox.Location = new System.Drawing.Point(216, 109);
            this.Width_textbox.Name = "Width_textbox";
            this.Width_textbox.Size = new System.Drawing.Size(146, 26);
            this.Width_textbox.TabIndex = 4;
            // 
            // Color_label
            // 
            this.Color_label.AutoSize = true;
            this.Color_label.Location = new System.Drawing.Point(216, 148);
            this.Color_label.Name = "Color_label";
            this.Color_label.Size = new System.Drawing.Size(50, 20);
            this.Color_label.TabIndex = 5;
            this.Color_label.Text = "Color:";
            // 
            // Color_textbox
            // 
            this.Color_textbox.Location = new System.Drawing.Point(216, 171);
            this.Color_textbox.Name = "Color_textbox";
            this.Color_textbox.Size = new System.Drawing.Size(146, 26);
            this.Color_textbox.TabIndex = 6;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(216, 258);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(146, 30);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 679);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.Enums_tabPage.ResumeLayout(false);
            this.SeasonNamesGroupBox.ResumeLayout(false);
            this.SeasonNamesGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Classes_TabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Enums_tabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox SeasonNamesGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Classes_TabPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox Color_textbox;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.TextBox Width_textbox;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.TextBox Length_textbox;
    }
}

