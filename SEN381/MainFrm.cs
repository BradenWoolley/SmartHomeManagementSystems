﻿using System;
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
using BusinessLayer;


namespace SEN381
{
    public partial class MainFrm : MaterialForm
    {
        public MainFrm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple400, Primary.DeepPurple600, MaterialSkin.Primary.Blue500, Accent.Teal100, TextShade.WHITE);
        }
    }
}
