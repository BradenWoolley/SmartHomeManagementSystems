using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class Products : UserControl
    {
        //TODO - Simply later with Product Management class
        //Add list box for display later
        BindingSource bs = new BindingSource();
        List<ProductCatalogue> catalogue = new List<ProductCatalogue>();
        List<Product> products;
        List<Actor> actors;

        public Products()
        {
            InitializeComponent();
            catalogue = new ProductCatalogue().GetCatalogue();
            bs.DataSource = catalogue;
            dgView.DataSource = bs;
        }

    }
}
