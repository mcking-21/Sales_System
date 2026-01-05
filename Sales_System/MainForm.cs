using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_System
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var MaterialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            MaterialSkinManager.AddFormToManage(this);
            MaterialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.BlueGrey800,
                MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500,
                MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE
            );
        }
    }
}
