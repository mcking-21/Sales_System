namespace Sales_System
{
    partial class CurrentOrders_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            item_pictureBox = new PictureBox();
            Minus_button = new PictureBox();
            Plus_button = new PictureBox();
            Quantity_label = new MaterialSkin.Controls.MaterialLabel();
            ItemName_label = new MaterialSkin.Controls.MaterialLabel();
            Remove_button = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)item_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minus_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Plus_button).BeginInit();
            SuspendLayout();
            // 
            // item_pictureBox
            // 
            item_pictureBox.Location = new Point(14, 13);
            item_pictureBox.Name = "item_pictureBox";
            item_pictureBox.Size = new Size(137, 137);
            item_pictureBox.TabIndex = 0;
            item_pictureBox.TabStop = false;
            // 
            // Minus_button
            // 
            Minus_button.Image = Properties.Resources.minus;
            Minus_button.Location = new Point(167, 74);
            Minus_button.Name = "Minus_button";
            Minus_button.Size = new Size(31, 31);
            Minus_button.SizeMode = PictureBoxSizeMode.Zoom;
            Minus_button.TabIndex = 1;
            Minus_button.TabStop = false;
            // 
            // Plus_button
            // 
            Plus_button.Image = Properties.Resources.plus;
            Plus_button.Location = new Point(309, 74);
            Plus_button.Name = "Plus_button";
            Plus_button.Size = new Size(31, 31);
            Plus_button.SizeMode = PictureBoxSizeMode.Zoom;
            Plus_button.TabIndex = 2;
            Plus_button.TabStop = false;
            // 
            // Quantity_label
            // 
            Quantity_label.Depth = 0;
            Quantity_label.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            Quantity_label.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            Quantity_label.Location = new Point(204, 71);
            Quantity_label.MouseState = MaterialSkin.MouseState.HOVER;
            Quantity_label.Name = "Quantity_label";
            Quantity_label.Size = new Size(99, 37);
            Quantity_label.TabIndex = 3;
            Quantity_label.Text = "0";
            Quantity_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ItemName_label
            // 
            ItemName_label.Depth = 0;
            ItemName_label.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ItemName_label.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            ItemName_label.Location = new Point(167, 13);
            ItemName_label.MouseState = MaterialSkin.MouseState.HOVER;
            ItemName_label.Name = "ItemName_label";
            ItemName_label.Size = new Size(173, 58);
            ItemName_label.TabIndex = 4;
            ItemName_label.Text = "materialLabel1";
            ItemName_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // Remove_button
            // 
            Remove_button.AutoSize = false;
            Remove_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Remove_button.BackColor = Color.Red;
            Remove_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Remove_button.Depth = 0;
            Remove_button.HighEmphasis = true;
            Remove_button.Icon = null;
            Remove_button.Location = new Point(167, 114);
            Remove_button.Margin = new Padding(4, 6, 4, 6);
            Remove_button.MouseState = MaterialSkin.MouseState.HOVER;
            Remove_button.Name = "Remove_button";
            Remove_button.NoAccentTextColor = Color.Empty;
            Remove_button.Size = new Size(173, 36);
            Remove_button.TabIndex = 5;
            Remove_button.Text = "Remove";
            Remove_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Remove_button.UseAccentColor = false;
            Remove_button.UseVisualStyleBackColor = false;
            // 
            // Orders_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Remove_button);
            Controls.Add(ItemName_label);
            Controls.Add(Quantity_label);
            Controls.Add(Plus_button);
            Controls.Add(Minus_button);
            Controls.Add(item_pictureBox);
            Name = "Orders_UserControl";
            Size = new Size(361, 168);
            ((System.ComponentModel.ISupportInitialize)item_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minus_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)Plus_button).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox item_pictureBox;
        private PictureBox Minus_button;
        private PictureBox Plus_button;
        private MaterialSkin.Controls.MaterialLabel Quantity_label;
        private MaterialSkin.Controls.MaterialLabel ItemName_label;
        private MaterialSkin.Controls.MaterialButton Remove_button;
    }
}
