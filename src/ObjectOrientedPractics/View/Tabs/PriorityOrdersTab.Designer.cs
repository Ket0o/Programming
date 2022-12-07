namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AmountDigitLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.SuspendLayout();
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(102, 479);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(93, 45);
            this.RemoveItemButton.TabIndex = 45;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOrderButton.Location = new System.Drawing.Point(522, 479);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(93, 45);
            this.ClearOrderButton.TabIndex = 44;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(3, 479);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(93, 45);
            this.AddItemButton.TabIndex = 43;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // AmountDigitLabel
            // 
            this.AmountDigitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountDigitLabel.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountDigitLabel.Location = new System.Drawing.Point(3, 450);
            this.AmountDigitLabel.Name = "AmountDigitLabel";
            this.AmountDigitLabel.Size = new System.Drawing.Size(612, 24);
            this.AmountDigitLabel.TabIndex = 42;
            this.AmountDigitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(562, 431);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 41;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 320);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(618, 108);
            this.OrderItemsListBox.TabIndex = 40;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 301);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 39;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(418, 2);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(93, 13);
            this.PriorityOptionsLabel.TabIndex = 38;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(494, 25);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeliveryTimeComboBox.TabIndex = 37;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(418, 28);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(70, 13);
            this.DeliveryTimeLabel.TabIndex = 36;
            this.DeliveryTimeLabel.Text = "Delivery time:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(53, 83);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 34;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(53, 30);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(121, 20);
            this.IDTextBox.TabIndex = 33;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(53, 56);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreatedTextBox.TabIndex = 32;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(0, 85);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 31;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(0, 59);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 30;
            this.CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(0, 33);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 29;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(0, 2);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectedOrderLabel.TabIndex = 28;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // addressControl1
            // 
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(3, 110);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(569, 204);
            this.addressControl1.TabIndex = 46;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressControl1);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.AmountDigitLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(621, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label AmountDigitLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private Controls.AddressControl addressControl1;
    }
}
