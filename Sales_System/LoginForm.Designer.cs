namespace Sales_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            Close_button = new PictureBox();
            Minimize_button = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            CreateAccount_linklabel = new LinkLabel();
            ForgotPassword_linklabel = new LinkLabel();
            Login_button = new MaterialSkin.Controls.MaterialButton();
            Password_textbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            Username_textbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Close_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(Close_button);
            panel2.Controls.Add(Minimize_button);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(CreateAccount_linklabel);
            panel2.Controls.Add(ForgotPassword_linklabel);
            panel2.Controls.Add(Login_button);
            panel2.Controls.Add(Password_textbox);
            panel2.Controls.Add(Username_textbox);
            panel2.Location = new Point(521, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 707);
            panel2.TabIndex = 1;
            // 
            // Close_button
            // 
            Close_button.BackColor = Color.Transparent;
            Close_button.Image = Properties.Resources.close;
            Close_button.Location = new Point(446, 0);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(42, 42);
            Close_button.SizeMode = PictureBoxSizeMode.StretchImage;
            Close_button.TabIndex = 7;
            Close_button.TabStop = false;
            Close_button.Click += Close_button_Click;
            Close_button.MouseEnter += Close_button_MouseEnter;
            Close_button.MouseLeave += Close_button_MouseLeave;
            // 
            // Minimize_button
            // 
            Minimize_button.BackColor = Color.Transparent;
            Minimize_button.Image = Properties.Resources.minimize;
            Minimize_button.Location = new Point(398, 0);
            Minimize_button.Name = "Minimize_button";
            Minimize_button.Size = new Size(42, 42);
            Minimize_button.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize_button.TabIndex = 8;
            Minimize_button.TabStop = false;
            Minimize_button.Click += Minimize_button_Click;
            Minimize_button.MouseEnter += Minimize_button_MouseEnter;
            Minimize_button.MouseLeave += Minimize_button_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.welcome;
            pictureBox3.Location = new Point(90, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.InitialImage = Properties.Resources.logo;
            pictureBox2.Location = new Point(148, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // CreateAccount_linklabel
            // 
            CreateAccount_linklabel.AutoSize = true;
            CreateAccount_linklabel.Location = new Point(317, 574);
            CreateAccount_linklabel.Name = "CreateAccount_linklabel";
            CreateAccount_linklabel.Size = new Size(128, 20);
            CreateAccount_linklabel.TabIndex = 4;
            CreateAccount_linklabel.TabStop = true;
            CreateAccount_linklabel.Text = "Create an account";
            // 
            // ForgotPassword_linklabel
            // 
            ForgotPassword_linklabel.AutoSize = true;
            ForgotPassword_linklabel.Location = new Point(50, 574);
            ForgotPassword_linklabel.Name = "ForgotPassword_linklabel";
            ForgotPassword_linklabel.Size = new Size(160, 20);
            ForgotPassword_linklabel.TabIndex = 3;
            ForgotPassword_linklabel.TabStop = true;
            ForgotPassword_linklabel.Text = "Forgot your password?";
            ForgotPassword_linklabel.TextAlign = ContentAlignment.TopRight;
            // 
            // Login_button
            // 
            Login_button.AutoSize = false;
            Login_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Login_button.Depth = 0;
            Login_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_button.HighEmphasis = true;
            Login_button.Icon = null;
            Login_button.Location = new Point(50, 508);
            Login_button.Margin = new Padding(4, 6, 4, 6);
            Login_button.MouseState = MaterialSkin.MouseState.HOVER;
            Login_button.Name = "Login_button";
            Login_button.NoAccentTextColor = Color.Empty;
            Login_button.Size = new Size(399, 45);
            Login_button.TabIndex = 2;
            Login_button.Text = "Login";
            Login_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Login_button.UseAccentColor = false;
            Login_button.UseVisualStyleBackColor = true;
            // 
            // Password_textbox
            // 
            Password_textbox.AllowPromptAsInput = true;
            Password_textbox.AnimateReadOnly = false;
            Password_textbox.AsciiOnly = false;
            Password_textbox.BackgroundImageLayout = ImageLayout.None;
            Password_textbox.BeepOnError = false;
            Password_textbox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            Password_textbox.Depth = 0;
            Password_textbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_textbox.HidePromptOnLeave = false;
            Password_textbox.HideSelection = true;
            Password_textbox.Hint = "Password";
            Password_textbox.InsertKeyMode = InsertKeyMode.Default;
            Password_textbox.LeadingIcon = null;
            Password_textbox.Location = new Point(50, 440);
            Password_textbox.Mask = "";
            Password_textbox.MaxLength = 32767;
            Password_textbox.MouseState = MaterialSkin.MouseState.OUT;
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '\0';
            Password_textbox.PrefixSuffixText = null;
            Password_textbox.PromptChar = '_';
            Password_textbox.ReadOnly = false;
            Password_textbox.RejectInputOnFirstFailure = false;
            Password_textbox.ResetOnPrompt = true;
            Password_textbox.ResetOnSpace = true;
            Password_textbox.RightToLeft = RightToLeft.No;
            Password_textbox.SelectedText = "";
            Password_textbox.SelectionLength = 0;
            Password_textbox.SelectionStart = 0;
            Password_textbox.ShortcutsEnabled = true;
            Password_textbox.Size = new Size(399, 48);
            Password_textbox.SkipLiterals = true;
            Password_textbox.TabIndex = 1;
            Password_textbox.TabStop = false;
            Password_textbox.TextAlign = HorizontalAlignment.Left;
            Password_textbox.TextMaskFormat = MaskFormat.IncludeLiterals;
            Password_textbox.TrailingIcon = null;
            Password_textbox.UseSystemPasswordChar = false;
            Password_textbox.ValidatingType = null;
            // 
            // Username_textbox
            // 
            Username_textbox.AllowPromptAsInput = true;
            Username_textbox.AnimateReadOnly = false;
            Username_textbox.AsciiOnly = false;
            Username_textbox.BackgroundImageLayout = ImageLayout.None;
            Username_textbox.BeepOnError = false;
            Username_textbox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            Username_textbox.Depth = 0;
            Username_textbox.Font = new Font("MS Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_textbox.HidePromptOnLeave = false;
            Username_textbox.HideSelection = true;
            Username_textbox.Hint = "Username/Email";
            Username_textbox.InsertKeyMode = InsertKeyMode.Default;
            Username_textbox.LeadingIcon = null;
            Username_textbox.Location = new Point(50, 372);
            Username_textbox.Mask = "";
            Username_textbox.MaxLength = 32767;
            Username_textbox.MouseState = MaterialSkin.MouseState.OUT;
            Username_textbox.Name = "Username_textbox";
            Username_textbox.PasswordChar = '\0';
            Username_textbox.PrefixSuffixText = null;
            Username_textbox.PromptChar = '_';
            Username_textbox.ReadOnly = false;
            Username_textbox.RejectInputOnFirstFailure = false;
            Username_textbox.ResetOnPrompt = true;
            Username_textbox.ResetOnSpace = true;
            Username_textbox.RightToLeft = RightToLeft.No;
            Username_textbox.SelectedText = "";
            Username_textbox.SelectionLength = 0;
            Username_textbox.SelectionStart = 0;
            Username_textbox.ShortcutsEnabled = true;
            Username_textbox.Size = new Size(399, 48);
            Username_textbox.SkipLiterals = true;
            Username_textbox.TabIndex = 0;
            Username_textbox.TabStop = false;
            Username_textbox.TextAlign = HorizontalAlignment.Left;
            Username_textbox.TextMaskFormat = MaskFormat.IncludeLiterals;
            Username_textbox.TrailingIcon = null;
            Username_textbox.UseSystemPasswordChar = false;
            Username_textbox.ValidatingType = null;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 713);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.food_aesthetic;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 713);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 695);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Close_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox Password_textbox;
        private MaterialSkin.Controls.MaterialMaskedTextBox Username_textbox;
        private LinkLabel CreateAccount_linklabel;
        private LinkLabel ForgotPassword_linklabel;
        private MaterialSkin.Controls.MaterialButton Login_button;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox Minimize_button;
        private PictureBox Close_button;
    }
}
