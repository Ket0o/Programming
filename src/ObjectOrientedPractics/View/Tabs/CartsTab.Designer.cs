namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.AddCartButton = new System.Windows.Forms.Button();
            this.ListBoxItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ListBoxCarts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(463, 26);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(436, 21);
            this.CustomerComboBox.TabIndex = 34;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(382, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(382, 29);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerLabel.TabIndex = 24;
            this.CustomerLabel.Text = "Customer:";
            // 
            // AddCartButton
            // 
            this.AddCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCartButton.Location = new System.Drawing.Point(10, 638);
            this.AddCartButton.Name = "AddCartButton";
            this.AddCartButton.Size = new System.Drawing.Size(118, 54);
            this.AddCartButton.TabIndex = 22;
            this.AddCartButton.Text = "Add To Cart";
            this.AddCartButton.UseVisualStyleBackColor = true;
            this.AddCartButton.Click += new System.EventHandler(this.AddCartButton_Click);
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxItems.FormattingEnabled = true;
            this.ListBoxItems.Location = new System.Drawing.Point(10, 29);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.Size = new System.Drawing.Size(366, 602);
            this.ListBoxItems.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(832, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Amount:";
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearCartButton.Location = new System.Drawing.Point(781, 318);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(118, 54);
            this.ClearCartButton.TabIndex = 36;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAmount.Location = new System.Drawing.Point(788, 286);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(111, 29);
            this.LabelAmount.TabIndex = 37;
            this.LabelAmount.Text = "4 999,90";
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(657, 318);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(118, 54);
            this.RemoveItemButton.TabIndex = 38;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateOrderButton.Location = new System.Drawing.Point(385, 318);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(118, 54);
            this.CreateOrderButton.TabIndex = 39;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ListBoxCarts
            // 
            this.ListBoxCarts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxCarts.FormattingEnabled = true;
            this.ListBoxCarts.Location = new System.Drawing.Point(385, 73);
            this.ListBoxCarts.Name = "ListBoxCarts";
            this.ListBoxCarts.Size = new System.Drawing.Size(514, 186);
            this.ListBoxCarts.TabIndex = 40;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListBoxCarts);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.LabelAmount);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AddCartButton);
            this.Controls.Add(this.ListBoxItems);
            this.Controls.Add(this.label1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(904, 699);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Button AddCartButton;
        private System.Windows.Forms.ListBox ListBoxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Label LabelAmount;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.ListBox ListBoxCarts;
    }
}
