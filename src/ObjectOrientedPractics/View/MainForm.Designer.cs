namespace ObjectOrientedPractics.View
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
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.ItemsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ItemsTabPage.Size = new System.Drawing.Size(909, 696);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(917, 722);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CustomersTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(909, 696);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(909, 696);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.ordersTab1);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(909, 696);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Items = null;
            this.ItemsTab.Location = new System.Drawing.Point(2, 2);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(1);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(905, 692);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Customers = null;
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(2, 2);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(1);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(905, 692);
            this.CustomersTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.CartsTab.Customers = null;
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(3, 3);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(903, 690);
            this.CartsTab.TabIndex = 0;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(3, 3);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(903, 690);
            this.ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(917, 722);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(933, 761);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ItemsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private View.Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private Tabs.OrdersTab ordersTab1;
    }
}

