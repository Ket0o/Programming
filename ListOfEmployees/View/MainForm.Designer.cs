namespace ListOfEmployees
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
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.SelectedEmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SelectedEmployeesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 20;
            this.listBoxEmployees.Location = new System.Drawing.Point(12, 12);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(291, 444);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // SelectedEmployeesGroupBox
            // 
            this.SelectedEmployeesGroupBox.Controls.Add(this.postTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.salaryTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.dateTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.fullNameTextBox);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label4);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label3);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label2);
            this.SelectedEmployeesGroupBox.Controls.Add(this.label1);
            this.SelectedEmployeesGroupBox.Location = new System.Drawing.Point(309, 12);
            this.SelectedEmployeesGroupBox.Name = "SelectedEmployeesGroupBox";
            this.SelectedEmployeesGroupBox.Size = new System.Drawing.Size(583, 205);
            this.SelectedEmployeesGroupBox.TabIndex = 1;
            this.SelectedEmployeesGroupBox.TabStop = false;
            this.SelectedEmployeesGroupBox.Text = "Selected Employee";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(168, 77);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(229, 26);
            this.postTextBox.TabIndex = 7;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(168, 157);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(229, 26);
            this.salaryTextBox.TabIndex = 6;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(168, 117);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(229, 26);
            this.dateTextBox.TabIndex = 5;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(168, 37);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(409, 26);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of employment:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Post:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(12, 476);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(53, 37);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "button1";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(71, 476);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(53, 37);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "button2";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(130, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(53, 37);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "button3";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 525);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.SelectedEmployeesGroupBox);
            this.Controls.Add(this.listBoxEmployees);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.SelectedEmployeesGroupBox.ResumeLayout(false);
            this.SelectedEmployeesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.GroupBox SelectedEmployeesGroupBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

