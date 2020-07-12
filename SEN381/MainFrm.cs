using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;


namespace SEN381
{
    public partial class MainFrm : MaterialForm
    {
        public MainFrm()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, Primary.Blue500, Accent.Teal200, TextShade.WHITE);
        }
    }
}
