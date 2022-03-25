﻿namespace Programming.View
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RatingFilmTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DurationMinutesFilmTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.GenreFilmTextBox = new System.Windows.Forms.TextBox();
            this.YearReleaseFilmTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameFilmTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FilmListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.ColorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Color_label = new System.Windows.Forms.Label();
            this.Width_label = new System.Windows.Forms.Label();
            this.LengthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.Length_label = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Enums_tabPage.SuspendLayout();
            this.SeasonNamesGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Classes_TabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.Classes_TabPage.Controls.Add(this.groupBox4);
            this.Classes_TabPage.Controls.Add(this.groupBox3);
            this.Classes_TabPage.Location = new System.Drawing.Point(4, 29);
            this.Classes_TabPage.Name = "Classes_TabPage";
            this.Classes_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Classes_TabPage.Size = new System.Drawing.Size(1014, 646);
            this.Classes_TabPage.TabIndex = 1;
            this.Classes_TabPage.Text = "Classes";
            this.Classes_TabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RatingFilmTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.DurationMinutesFilmTextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.FindFilmButton);
            this.groupBox4.Controls.Add(this.GenreFilmTextBox);
            this.groupBox4.Controls.Add(this.YearReleaseFilmTextBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.NameFilmTextBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.FilmListBox);
            this.groupBox4.Location = new System.Drawing.Point(525, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 390);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Films";
            // 
            // RatingFilmTextBox
            // 
            this.RatingFilmTextBox.Location = new System.Drawing.Point(216, 288);
            this.RatingFilmTextBox.Name = "RatingFilmTextBox";
            this.RatingFilmTextBox.Size = new System.Drawing.Size(146, 26);
            this.RatingFilmTextBox.TabIndex = 11;
            this.RatingFilmTextBox.TextChanged += new System.EventHandler(this.RatingFilmTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rating:";
            // 
            // DurationMinutesFilmTextBox
            // 
            this.DurationMinutesFilmTextBox.Location = new System.Drawing.Point(216, 228);
            this.DurationMinutesFilmTextBox.Name = "DurationMinutesFilmTextBox";
            this.DurationMinutesFilmTextBox.Size = new System.Drawing.Size(146, 26);
            this.DurationMinutesFilmTextBox.TabIndex = 9;
            this.DurationMinutesFilmTextBox.TextChanged += new System.EventHandler(this.DurationMinutesFilmTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = " Duration in minutes:";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(216, 336);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(146, 30);
            this.FindFilmButton.TabIndex = 7;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
            // 
            // GenreFilmTextBox
            // 
            this.GenreFilmTextBox.Location = new System.Drawing.Point(216, 108);
            this.GenreFilmTextBox.Name = "GenreFilmTextBox";
            this.GenreFilmTextBox.Size = new System.Drawing.Size(146, 26);
            this.GenreFilmTextBox.TabIndex = 4;
            this.GenreFilmTextBox.TextChanged += new System.EventHandler(this.GenreFilmTextBox_TextChanged);
            // 
            // YearReleaseFilmTextBox
            // 
            this.YearReleaseFilmTextBox.Location = new System.Drawing.Point(216, 168);
            this.YearReleaseFilmTextBox.Name = "YearReleaseFilmTextBox";
            this.YearReleaseFilmTextBox.Size = new System.Drawing.Size(146, 26);
            this.YearReleaseFilmTextBox.TabIndex = 6;
            this.YearReleaseFilmTextBox.TextChanged += new System.EventHandler(this.YearReleaseFilmTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Year Release:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genre:";
            // 
            // NameFilmTextBox
            // 
            this.NameFilmTextBox.Location = new System.Drawing.Point(216, 48);
            this.NameFilmTextBox.Name = "NameFilmTextBox";
            this.NameFilmTextBox.Size = new System.Drawing.Size(146, 26);
            this.NameFilmTextBox.TabIndex = 2;
            this.NameFilmTextBox.TextChanged += new System.EventHandler(this.NameFilmTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // FilmListBox
            // 
            this.FilmListBox.FormattingEnabled = true;
            this.FilmListBox.ItemHeight = 20;
            this.FilmListBox.Location = new System.Drawing.Point(6, 25);
            this.FilmListBox.Name = "FilmListBox";
            this.FilmListBox.Size = new System.Drawing.Size(200, 264);
            this.FilmListBox.TabIndex = 0;
            this.FilmListBox.SelectedIndexChanged += new System.EventHandler(this.FilmListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FindButton);
            this.groupBox3.Controls.Add(this.WidthRectangleTextBox);
            this.groupBox3.Controls.Add(this.ColorRectangleTextBox);
            this.groupBox3.Controls.Add(this.Color_label);
            this.groupBox3.Controls.Add(this.Width_label);
            this.groupBox3.Controls.Add(this.LengthRectangleTextBox);
            this.groupBox3.Controls.Add(this.Length_label);
            this.groupBox3.Controls.Add(this.RectanglesListBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 390);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rectangles";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(216, 258);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(146, 30);
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
            this.RectanglesListBox.Size = new System.Drawing.Size(200, 264);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TextBox ColorRectangleTextBox;
        private System.Windows.Forms.Label Color_label;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.Label Width_label;
        private System.Windows.Forms.TextBox LengthRectangleTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox RatingFilmTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DurationMinutesFilmTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox GenreFilmTextBox;
        private System.Windows.Forms.TextBox YearReleaseFilmTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameFilmTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox FilmListBox;
    }
}

