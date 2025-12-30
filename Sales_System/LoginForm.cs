using MaterialSkin.Controls;

namespace Sales_System
{
    //private int alpha = 0; 
    //private Timer glowTimer = new Timer();
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.WhiteSmoke;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackColor = Color.Transparent;
        }

        private void Minimize_button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_button.BackColor = Color.WhiteSmoke;
        }

        private void Minimize_button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_button.BackColor = Color.Transparent;
        }
    }
}
