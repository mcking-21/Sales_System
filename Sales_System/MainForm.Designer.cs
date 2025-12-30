namespace Sales_System
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            Order_tab = new TabPage();
            Transactions_tab = new TabPage();
            Dashboard_tab = new TabPage();
            DeliveryItems_tab = new TabPage();
            Inventory_tab = new TabPage();
            ReturnRefund_tab = new TabPage();
            Profile_tab = new TabPage();
            TabControlIcons = new ImageList(components);
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.AllowDrop = true;
            materialTabControl1.Appearance = TabAppearance.FlatButtons;
            materialTabControl1.Controls.Add(Order_tab);
            materialTabControl1.Controls.Add(Transactions_tab);
            materialTabControl1.Controls.Add(Dashboard_tab);
            materialTabControl1.Controls.Add(DeliveryItems_tab);
            materialTabControl1.Controls.Add(Inventory_tab);
            materialTabControl1.Controls.Add(ReturnRefund_tab);
            materialTabControl1.Controls.Add(Profile_tab);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.HotTrack = true;
            materialTabControl1.ImageList = TabControlIcons;
            materialTabControl1.ItemSize = new Size(78, 28);
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1914, 1013);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.TabStop = false;
            // 
            // Order_tab
            // 
            Order_tab.BackColor = SystemColors.Control;
            Order_tab.ImageKey = "Order.png";
            Order_tab.Location = new Point(4, 32);
            Order_tab.Name = "Order_tab";
            Order_tab.Size = new Size(1906, 977);
            Order_tab.TabIndex = 2;
            Order_tab.Text = "Orders";
            // 
            // Transactions_tab
            // 
            Transactions_tab.BackColor = SystemColors.Control;
            Transactions_tab.ImageKey = "Transaction.png";
            Transactions_tab.Location = new Point(4, 32);
            Transactions_tab.Name = "Transactions_tab";
            Transactions_tab.Padding = new Padding(3);
            Transactions_tab.Size = new Size(786, 347);
            Transactions_tab.TabIndex = 1;
            Transactions_tab.Text = "Transactions";
            // 
            // Dashboard_tab
            // 
            Dashboard_tab.ImageKey = "Dashboard.png";
            Dashboard_tab.Location = new Point(4, 32);
            Dashboard_tab.Name = "Dashboard_tab";
            Dashboard_tab.Padding = new Padding(3);
            Dashboard_tab.Size = new Size(786, 347);
            Dashboard_tab.TabIndex = 0;
            Dashboard_tab.Text = "Dashboard";
            Dashboard_tab.UseVisualStyleBackColor = true;
            // 
            // DeliveryItems_tab
            // 
            DeliveryItems_tab.ImageKey = "Delivery.png";
            DeliveryItems_tab.Location = new Point(4, 32);
            DeliveryItems_tab.Name = "DeliveryItems_tab";
            DeliveryItems_tab.Size = new Size(786, 347);
            DeliveryItems_tab.TabIndex = 3;
            DeliveryItems_tab.Text = "Delivery";
            DeliveryItems_tab.UseVisualStyleBackColor = true;
            // 
            // Inventory_tab
            // 
            Inventory_tab.ImageKey = "Inventory.png";
            Inventory_tab.Location = new Point(4, 32);
            Inventory_tab.Name = "Inventory_tab";
            Inventory_tab.Size = new Size(786, 347);
            Inventory_tab.TabIndex = 6;
            Inventory_tab.Text = "Inventory";
            Inventory_tab.UseVisualStyleBackColor = true;
            // 
            // ReturnRefund_tab
            // 
            ReturnRefund_tab.ImageKey = "Return.png";
            ReturnRefund_tab.Location = new Point(4, 32);
            ReturnRefund_tab.Name = "ReturnRefund_tab";
            ReturnRefund_tab.Size = new Size(786, 347);
            ReturnRefund_tab.TabIndex = 5;
            ReturnRefund_tab.Text = "Return/Refund";
            ReturnRefund_tab.UseVisualStyleBackColor = true;
            // 
            // Profile_tab
            // 
            Profile_tab.ImageKey = "Profile.png";
            Profile_tab.Location = new Point(4, 32);
            Profile_tab.Name = "Profile_tab";
            Profile_tab.Size = new Size(786, 347);
            Profile_tab.TabIndex = 4;
            Profile_tab.Text = "Profile";
            Profile_tab.UseVisualStyleBackColor = true;
            // 
            // TabControlIcons
            // 
            TabControlIcons.ColorDepth = ColorDepth.Depth32Bit;
            TabControlIcons.ImageStream = (ImageListStreamer)resources.GetObject("TabControlIcons.ImageStream");
            TabControlIcons.TransparentColor = Color.Transparent;
            TabControlIcons.Images.SetKeyName(0, "Dashboard.png");
            TabControlIcons.Images.SetKeyName(1, "Delivery.png");
            TabControlIcons.Images.SetKeyName(2, "Inventory.png");
            TabControlIcons.Images.SetKeyName(3, "Order.png");
            TabControlIcons.Images.SetKeyName(4, "Profile.png");
            TabControlIcons.Images.SetKeyName(5, "Return.png");
            TabControlIcons.Images.SetKeyName(6, "Transaction.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1920, 1080);
            Controls.Add(materialTabControl1);
            DoubleBuffered = false;
            DrawerAutoHide = false;
            DrawerIsOpen = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            DrawerUseColors = true;
            ForeColor = SystemColors.ControlText;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Dashboard_tab;
        private TabPage Transactions_tab;
        private TabPage Order_tab;
        private TabPage DeliveryItems_tab;
        private TabPage Profile_tab;
        private TabPage ReturnRefund_tab;
        private TabPage Inventory_tab;
        private ImageList TabControlIcons;
    }
}