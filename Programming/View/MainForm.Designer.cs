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
            this.Classes_TabPage = new System.Windows.Forms.TabPage();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Color_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Length_label = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.Enums_tabPage = new System.Windows.Forms.TabPage();
            this.SeasonNamesGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Rectangles_TabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.Classes_TabPage.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.Enums_tabPage.SuspendLayout();
            this.SeasonNamesGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Rectangles_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Classes_TabPage
            // 
            this.Classes_TabPage.Controls.Add(this.moviesControl1);
            this.Classes_TabPage.Controls.Add(this.RectangleGroupBox);
            this.Classes_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Classes_TabPage.Name = "Classes_TabPage";
            this.Classes_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Classes_TabPage.Size = new System.Drawing.Size(1014, 645);
            this.Classes_TabPage.TabIndex = 1;
            this.Classes_TabPage.Text = "Classes";
            this.Classes_TabPage.UseVisualStyleBackColor = true;
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.label13);
            this.RectangleGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.label12);
            this.RectangleGroupBox.Controls.Add(this.YRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.label11);
            this.RectangleGroupBox.Controls.Add(this.XRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.FindButton);
            this.RectangleGroupBox.Controls.Add(this.WidthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.Color_label);
            this.RectangleGroupBox.Controls.Add(this.Width_label);
            this.RectangleGroupBox.Controls.Add(this.LengthRectangleTextBox);
            this.RectangleGroupBox.Controls.Add(this.Length_label);
            this.RectangleGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 0);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(496, 448);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Id:";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Enabled = false;
            this.IdRectangleTextBox.Location = new System.Drawing.Point(216, 357);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.IdRectangleTextBox.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Y:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Enabled = false;
            this.YRectangleTextBox.Location = new System.Drawing.Point(216, 295);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.YRectangleTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "X:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Enabled = false;
            this.XRectangleTextBox.Location = new System.Drawing.Point(216, 232);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.XRectangleTextBox.TabIndex = 8;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(216, 398);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(146, 31);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(216, 109);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.WidthRectangleTextBox.TabIndex = 4;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // ColorRectangleTextBox
            // 
            this.ColorRectangleTextBox.Location = new System.Drawing.Point(216, 171);
            this.ColorRectangleTextBox.Name = "ColorRectangleTextBox";
            this.ColorRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.ColorRectangleTextBox.TabIndex = 6;
            this.ColorRectangleTextBox.TextChanged += new System.EventHandler(this.ColorRectangleTextBox_TextChanged);
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
            // Width_label
            // 
            this.Width_label.AutoSize = true;
            this.Width_label.Location = new System.Drawing.Point(212, 86);
            this.Width_label.Name = "Width_label";
            this.Width_label.Size = new System.Drawing.Size(54, 20);
            this.Width_label.TabIndex = 3;
            this.Width_label.Text = "Width:";
            // 
            // LengthRectangleTextBox
            // 
            this.LengthRectangleTextBox.Location = new System.Drawing.Point(216, 48);
            this.LengthRectangleTextBox.Name = "LengthRectangleTextBox";
            this.LengthRectangleTextBox.Size = new System.Drawing.Size(146, 26);
            this.LengthRectangleTextBox.TabIndex = 2;
            this.LengthRectangleTextBox.TextChanged += new System.EventHandler(this.LengthRectangleTextBox_TextChanged);
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
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 25);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(200, 404);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // Enums_tabPage
            // 
            this.Enums_tabPage.Controls.Add(this.SeasonNamesGroupBox);
            this.Enums_tabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.Enums_tabPage.Controls.Add(this.EnumerationsGroupBox);
            this.Enums_tabPage.Location = new System.Drawing.Point(4, 29);
            this.Enums_tabPage.Name = "Enums_tabPage";
            this.Enums_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Enums_tabPage.Size = new System.Drawing.Size(1014, 645);
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
            this.SeasonNamesGroupBox.Size = new System.Drawing.Size(510, 215);
            this.SeasonNamesGroupBox.TabIndex = 2;
            this.SeasonNamesGroupBox.TabStop = false;
            this.SeasonNamesGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(338, 55);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(112, 31);
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
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(324, 28);
            this.SeasonNamesComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.label4);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 418);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(488, 215);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
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
            this.ParseWeekdayButton.Location = new System.Drawing.Point(338, 55);
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
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Controls.Add(this.label3);
            this.EnumerationsGroupBox.Controls.Add(this.label2);
            this.EnumerationsGroupBox.Controls.Add(this.label1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(3, 0);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(1004, 412);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(520, 55);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(224, 26);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(262, 55);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(224, 264);
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
            this.EnumsListBox.Size = new System.Drawing.Size(224, 264);
            this.EnumsListBox.TabIndex = 3;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose enumeration:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Enums_tabPage);
            this.tabControl1.Controls.Add(this.Classes_TabPage);
            this.tabControl1.Controls.Add(this.Rectangles_TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 678);
            this.tabControl1.TabIndex = 0;
            // 
            // Rectangles_TabPage
            // 
            this.Rectangles_TabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.Rectangles_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Rectangles_TabPage.Name = "Rectangles_TabPage";
            this.Rectangles_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Rectangles_TabPage.Size = new System.Drawing.Size(1014, 645);
            this.Rectangles_TabPage.TabIndex = 2;
            this.Rectangles_TabPage.Text = "Rectangles";
            this.Rectangles_TabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(1014, 645);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(508, 0);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(506, 456);
            this.moviesControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 678);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Classes_TabPage.ResumeLayout(false);
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.Enums_tabPage.ResumeLayout(false);
            this.SeasonNamesGroupBox.ResumeLayout(false);
            this.SeasonNamesGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Rectangles_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Classes_TabPage;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.TabPage Enums_tabPage;
        private System.Windows.Forms.GroupBox SeasonNamesGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Rectangles_TabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.MoviesControl moviesControl1;
    }
}

