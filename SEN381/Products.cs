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
        BindingSource bsComponents = new BindingSource();

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

            cb_ProductGroup_Insert.DataSource = bs;
            cb_ProductGroup_Insert.DisplayMember = "ProductSuite";

            cbProductGroup_Update.DataSource = bs;
            cbProductGroup_Update.DisplayMember = "ProductSuite";

           

            RefreshActors();
            RefreshControllers();
            RefreshSensors();

            AllComponents();
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

        private void cb_ProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ProductGroup_Insert.DataSource = bs;
            cb_ProductGroup_Insert.DisplayMember = "ProductSuite";
        }

        //TODO ~ Redo this method and create Stored Procedure to handle its request
        void AllComponents()
        {
            bsComponents.Clear();

            if(product != null)
            {
                List<BusinessLayer.Component> components = new List<BusinessLayer.Component>();

                foreach (var item in actors)
                {
                    components.Add(new BusinessLayer.Component(item.ID, item.Name, item.Cost, "Actor"));
                }

                foreach (var item in controllers)
                {
                    components.Add(new BusinessLayer.Component(item.ID, item.Name, item.Cost, "Controller"));
                }

                foreach (var item in sensors)
                {
                    components.Add(new BusinessLayer.Component(item.ID, item.Name, item.Cost, "Sensor"));
                }

                bsComponents.DataSource = components;
                cbProductName_Update.DataSource = bsComponents;
                cbProductName_Update.DisplayMember = "Name";
            }
        }

        private void btnSubmitNewProduct_Click(object sender, EventArgs e)
        {
            //Checks if component is null
            if (string.IsNullOrWhiteSpace(txtComponentName_Insert.Text) || txtComponentName_Insert.Text.Length == 0)
            {
                MessageBox.Show("Component Name cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComponentName_Insert.Clear();
            }

            double costDouble;
            //Checks if component cost is empty or zero 
            if(double.TryParse(txtCost_Insert.Text, out costDouble))
            {
                if (string.IsNullOrWhiteSpace(txtCost_Insert.Text) || double.Parse(txtCost_Insert.Text.ToString()) == 0.0)
                {
                    MessageBox.Show("Cost cannot be empty!", "Invalid Cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCost_Insert.Clear();
                }
            }      

            //checks if component is numeric
            else if(!double.TryParse(txtCost_Insert.Text, out costDouble))
            {
                MessageBox.Show("Cost must be a number!", "Invalid Cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost_Insert.Clear();
            }
            //Checks that component type is a valid selection
            if(cb_ComponentType_Insert.SelectedIndex < 0)
            {
                MessageBox.Show("Component must have a type!", "Missing Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            //If all work then send information to business layer
            if(!string.IsNullOrWhiteSpace(txtComponentName_Insert.Text) && txtComponentName_Insert.Text.Length > 0 
                && !string.IsNullOrWhiteSpace(txtCost_Insert.Text) && double.TryParse(txtCost_Insert.Text, out costDouble) && double.Parse(txtCost_Insert.Text.ToString()) >= 0.0 && cb_ComponentType_Insert.SelectedIndex >= 0)
            {
                MessageBox.Show("ALL FIELDS VALID");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Prevent invalid component
            if(cbProductName_Update.SelectedIndex < 0)
            {
                MessageBox.Show("Invalid product");
            }

            //Checks if component is null
            if (string.IsNullOrWhiteSpace(txtComponentName_Update.Text) || txtComponentName_Update.Text.Length == 0)
            {
                MessageBox.Show("Component Name cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComponentName_Update.Clear();
            }

            double costDouble;
            //Checks if component cost is empty or zero 
            if (double.TryParse(txtCost_Update.Text, out costDouble))
            {
                if (string.IsNullOrWhiteSpace(txtCost_Update.Text) || double.Parse(txtCost_Update.Text.ToString()) == 0.0)
                {
                    MessageBox.Show("Cost cannot be empty!", "Invalid Cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCost_Update.Clear();
                }
            }

            //checks if component is numeric
            else if (!double.TryParse(txtCost_Update.Text, out costDouble))
            {
                MessageBox.Show("Cost must be a number!", "Invalid Cost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost_Update.Clear();
            }
            //Checks that component type is a valid selection
            if (cb_ComponentType_Update.SelectedIndex < 0)
            {
                MessageBox.Show("Component must have a type!", "Missing Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //If all work then send information to business layer
            if (!string.IsNullOrWhiteSpace(txtComponentName_Update.Text) && txtComponentName_Update.Text.Length > 0
                && !string.IsNullOrWhiteSpace(txtCost_Update.Text) && double.TryParse(txtCost_Update.Text, out costDouble) 
                && double.Parse(txtCost_Update.Text.ToString()) >= 0.0 && cb_ComponentType_Update.SelectedIndex >= 0
                && cbProductName_Update.SelectedIndex >= 0)
            {
                MessageBox.Show("ALL FIELDS VALID");
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //Prevent invalid component
            if (cbProductName_Update.SelectedIndex < 0)
            {
                MessageBox.Show("Cannot delete non-existent product");
            }

            else
            {
                MessageBox.Show("Cannot delete non-existent product");
            }
        }
    }
}
