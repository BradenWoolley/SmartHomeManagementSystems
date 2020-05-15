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
using Syncfusion.Windows.Forms.Interop;

namespace SEN381
{
    public partial class Products : UserControl
    {
        //TODO - Simplify later with Product Management class
        //Add list box for display later
        BindingSource bs = new BindingSource();

        BindingSource bsActors = new BindingSource();
        BindingSource bsControllers = new BindingSource();
        BindingSource bsSensors = new BindingSource();

        List<Product> catalogue = new List<Product>();

        Product product;

        List<Actor> actors = new List<Actor>();
        List<Controller> controllers = new List<Controller>();
        List<Sensor> sensors = new List<Sensor>();
        

        public Products()
        {
            InitializeComponent();
            catalogue = new Product().GetProducts();
            bs.DataSource = catalogue;
            lsBox_products.DataSource = bs;
            lsBox_products.DisplayMember = "ProductSuite";

            RefreshActors();
            RefreshControllers();
            RefreshSensors();
        }

        private void lsBox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshActors();
            RefreshControllers();
            RefreshSensors();
        }

        void RefreshActors()
        {
            bsActors.Clear();

            product = (Product)bs.Current;

            if (product != null)
            {
                actors = new Actor().GetActors(product.ProductId);
                bsActors.DataSource = actors;
                dgView_Actors.DataSource = bsActors;
            }
        }

        void RefreshControllers()
        {
            bsControllers.Clear();

            if (product != null)
            {
                controllers = new Controller().GetControllers(product.ProductId);
                bsControllers.DataSource = controllers;
                dgView_Controllers.DataSource = bsControllers;
            }
        }

        void RefreshSensors()
        {
            bsSensors.Clear();

            if (product != null)
            {
                sensors = new Sensor().GetSensors(product.ProductId);
                bsSensors.DataSource = sensors;
                dgView_Sensors.DataSource = bsSensors;
            }
        }
    }
}
