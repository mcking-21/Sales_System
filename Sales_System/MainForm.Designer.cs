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
            panel1 = new Panel();
            panel2 = new Panel();
            Subtotal_label = new MaterialSkin.Controls.MaterialLabel();
            Discoount_Label = new MaterialSkin.Controls.MaterialLabel();
            ShippingFee_label = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            Total_label = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Transactions_tab = new TabPage();
            Dashboard_tab = new TabPage();
            DeliveryItems_tab = new TabPage();
            Inventory_tab = new TabPage();
            ReturnRefund_tab = new TabPage();
            Profile_tab = new TabPage();
            TabControlIcons = new ImageList(components);
            materialTabControl1.SuspendLayout();
            Order_tab.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            Order_tab.BackColor = SystemColors.ControlLight;
            Order_tab.Controls.Add(panel1);
            Order_tab.ImageKey = "Order.png";
            Order_tab.Location = new Point(4, 32);
            Order_tab.Name = "Order_tab";
            Order_tab.Size = new Size(1906, 977);
            Order_tab.TabIndex = 2;
            Order_tab.Text = "Orders";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(materialLabel1);
            panel1.Location = new Point(1336, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 971);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(Subtotal_label);
            panel2.Controls.Add(Discoount_Label);
            panel2.Controls.Add(ShippingFee_label);
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(Total_label);
            panel2.Controls.Add(materialLabel2);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(23, 539);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 338);
            panel2.TabIndex = 3;
            // 
            // Subtotal_label
            // 
            Subtotal_label.Depth = 0;
            Subtotal_label.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Subtotal_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Subtotal_label.Location = new Point(192, 153);
            Subtotal_label.MouseState = MaterialSkin.MouseState.HOVER;
            Subtotal_label.Name = "Subtotal_label";
            Subtotal_label.Size = new Size(145, 37);
            Subtotal_label.TabIndex = 10;
            Subtotal_label.Text = "246.00";
            // 
            // Discoount_Label
            // 
            Discoount_Label.Depth = 0;
            Discoount_Label.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Discoount_Label.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Discoount_Label.Location = new Point(192, 190);
            Discoount_Label.MouseState = MaterialSkin.MouseState.HOVER;
            Discoount_Label.Name = "Discoount_Label";
            Discoount_Label.Size = new Size(145, 37);
            Discoount_Label.TabIndex = 9;
            Discoount_Label.Text = "-50.00";
            // 
            // ShippingFee_label
            // 
            ShippingFee_label.Depth = 0;
            ShippingFee_label.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            ShippingFee_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            ShippingFee_label.Location = new Point(192, 227);
            ShippingFee_label.MouseState = MaterialSkin.MouseState.HOVER;
            ShippingFee_label.Name = "ShippingFee_label";
            ShippingFee_label.Size = new Size(145, 37);
            ShippingFee_label.TabIndex = 8;
            ShippingFee_label.Text = "90.00";
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel5.Location = new Point(12, 153);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(148, 37);
            materialLabel5.TabIndex = 7;
            materialLabel5.Text = "Subtotal:";
            materialLabel5.TextAlign = ContentAlignment.TopRight;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel4.Location = new Point(12, 190);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(148, 37);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Discount:";
            materialLabel4.TextAlign = ContentAlignment.TopRight;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(12, 227);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(148, 37);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Shipping Fee:";
            materialLabel3.TextAlign = ContentAlignment.TopRight;
            // 
            // Total_label
            // 
            Total_label.Depth = 0;
            Total_label.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            Total_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            Total_label.Location = new Point(192, 264);
            Total_label.MouseState = MaterialSkin.MouseState.HOVER;
            Total_label.Name = "Total_label";
            Total_label.Size = new Size(307, 64);
            Total_label.TabIndex = 4;
            Total_label.Text = "286.00";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel2.Location = new Point(12, 264);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(151, 64);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "Total:";
            materialLabel2.TextAlign = ContentAlignment.TopRight;
            materialLabel2.Click += materialLabel2_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Bottom;
            materialButton1.FlatStyle = FlatStyle.Popup;
            materialButton1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(0, 903);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(567, 68);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Checkout";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.BackColor = Color.White;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(13, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(540, 55);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Current Order";
            // 
            // Transactions_tab
            // 
            Transactions_tab.BackColor = SystemColors.Control;
            Transactions_tab.ImageKey = "Transaction.png";
            Transactions_tab.Location = new Point(4, 32);
            Transactions_tab.Name = "Transactions_tab";
            Transactions_tab.Padding = new Padding(3);
            Transactions_tab.Size = new Size(1906, 977);
            Transactions_tab.TabIndex = 1;
            Transactions_tab.Text = "Transactions";
            // 
            // Dashboard_tab
            // 
            Dashboard_tab.ImageKey = "Dashboard.png";
            Dashboard_tab.Location = new Point(4, 32);
            Dashboard_tab.Name = "Dashboard_tab";
            Dashboard_tab.Padding = new Padding(3);
            Dashboard_tab.Size = new Size(1906, 977);
            Dashboard_tab.TabIndex = 0;
            Dashboard_tab.Text = "Dashboard";
            Dashboard_tab.UseVisualStyleBackColor = true;
            // 
            // DeliveryItems_tab
            // 
            DeliveryItems_tab.ImageKey = "Delivery.png";
            DeliveryItems_tab.Location = new Point(4, 32);
            DeliveryItems_tab.Name = "DeliveryItems_tab";
            DeliveryItems_tab.Size = new Size(1906, 977);
            DeliveryItems_tab.TabIndex = 3;
            DeliveryItems_tab.Text = "Delivery";
            DeliveryItems_tab.UseVisualStyleBackColor = true;
            // 
            // Inventory_tab
            // 
            Inventory_tab.ImageKey = "Inventory.png";
            Inventory_tab.Location = new Point(4, 32);
            Inventory_tab.Name = "Inventory_tab";
            Inventory_tab.Size = new Size(1906, 977);
            Inventory_tab.TabIndex = 6;
            Inventory_tab.Text = "Inventory";
            Inventory_tab.UseVisualStyleBackColor = true;
            // 
            // ReturnRefund_tab
            // 
            ReturnRefund_tab.ImageKey = "Return.png";
            ReturnRefund_tab.Location = new Point(4, 32);
            ReturnRefund_tab.Name = "ReturnRefund_tab";
            ReturnRefund_tab.Size = new Size(1906, 977);
            ReturnRefund_tab.TabIndex = 5;
            ReturnRefund_tab.Text = "Return/Refund";
            ReturnRefund_tab.UseVisualStyleBackColor = true;
            // 
            // Profile_tab
            // 
            Profile_tab.ImageKey = "Profile.png";
            Profile_tab.Location = new Point(4, 32);
            Profile_tab.Name = "Profile_tab";
            Profile_tab.Size = new Size(1906, 977);
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
            Order_tab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Dashboard_tab;
        private TabPage Transactions_tab;
        private TabPage DeliveryItems_tab;
        private TabPage Profile_tab;
        private TabPage ReturnRefund_tab;
        private TabPage Inventory_tab;
        private ImageList TabControlIcons;
        private TabPage Order_tab;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel Total_label;
        private MaterialSkin.Controls.MaterialLabel Subtotal_label;
        private MaterialSkin.Controls.MaterialLabel Discoount_Label;
        private MaterialSkin.Controls.MaterialLabel ShippingFee_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}