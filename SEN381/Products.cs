using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SEN381
{
    public partial class Products : UserControl
    {

        BindingSource bs = new BindingSource();
        BindingSource bsActors = new BindingSource();
        BindingSource bsControllers = new BindingSource();
        BindingSource bsSensors = new BindingSource();
        BindingSource bsComponents = new BindingSource();

        List<Product> catalogue;// = new List<Product>();
        List<Actor> actors = new List<Actor>();
        List<Controller> controllers = new List<Controller>();
        List<Sensor> sensors = new List<Sensor>();

        ProductManagement management = new ProductManagement();
        Product product;


        public Products()
        {
            InitializeComponent();
            RefreshAll();
        }

        private void lsBox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshActors();
            RefreshControllers();
            RefreshSensors();
        }

        private void cb_ProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ProductGroup_Insert.DataSource = bs;
            cb_ProductGroup_Insert.DisplayMember = "ProductSuite";
        }

        private void cbProductName_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusinessLayer.Component comp = (BusinessLayer.Component)cbProductName_Update.SelectedItem;
            if (comp != null)
            {
                txtComponentName_Update.Text = comp.Name;
                txtCost_Update.Text = comp.ID.ToString();
                cb_ComponentType_Update.SelectedIndex = (comp.Type - 1);
            }

        }

        //Clears and resets all bindingsources
        void RefreshAll()
        {
            bs.Clear();
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
        //Clears and resets Actos bindingsources
        void RefreshActors()
        {
            bsActors.Clear();
            actors.Clear();

            product = (Product)bs.Current;

            if (product != null)
            {
                actors = new Actor().GetActors(product.ProductId);
                bsActors.DataSource = actors;
                dgView_Actors.DataSource = bsActors;
            }
        }
        //Clears and resets Controller bindingsources
        void RefreshControllers()
        {
            bsControllers.Clear();
            controllers.Clear();

            if (product != null)
            {
                controllers = new Controller().GetControllers(product.ProductId);
                bsControllers.DataSource = controllers;
                dgView_Controllers.DataSource = bsControllers;
            }
        }
        //Clears and resets Sensor bindingsources
        void RefreshSensors()
        {
            bsSensors.Clear();
            sensors.Clear();

            if (product != null)
            {
                sensors = new Sensor().GetSensors(product.ProductId);
                bsSensors.DataSource = sensors;
                dgView_Sensors.DataSource = bsSensors;
            }
        }

        //Refreshes comboboxes datasource
        void AllComponents()
        {
            bsComponents.Clear();
            

            if (product != null)
            {
                List<BusinessLayer.Component> components = new List<BusinessLayer.Component>();
                components.Clear();

                components = new BusinessLayer.Component().GetComponents();

                bsComponents.DataSource = components;

                cbProductName_Update.DataSource = bsComponents;
                cbProductName_Update.DisplayMember = "Name";

                cbProductName_Delete.DataSource = bsComponents;
                cbProductName_Delete.DisplayMember = "Name";
            }
        }
        //Insert new component after checking fields ~ TODO move index increment to business layer
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
                management.Insert(txtComponentName_Insert.Text, cb_ComponentType_Insert.SelectedIndex + 1, double.Parse(txtCost_Insert.Text), product.ProductId);

                RefreshAll();

                MessageBox.Show($"{txtComponentName_Insert.Text} successfully added");
                txtComponentName_Insert.Clear();
                txtCost_Insert.Clear();

            }
        }

        //TODO Correct multi-product group updates and move index increment to business layer
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
                BusinessLayer.Component comp = (BusinessLayer.Component)cbProductName_Update.SelectedItem;
                if (comp != null)
                {
                    management.Update(comp.ID, txtComponentName_Update.Text, (cb_ComponentType_Update.SelectedIndex+1), double.Parse(txtCost_Update.Text), (cbProductGroup_Update.SelectedIndex+1));
                    RefreshAll();
                    MessageBox.Show($"Updated {comp.Name} To {txtComponentName_Update.Text} {txtCost_Update.Text} {cb_ComponentType_Update.SelectedItem.ToString()}");
                }
                    
            }

        }
        //Deletes component from database
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            
            BusinessLayer.Component comp = (BusinessLayer.Component)cbProductName_Delete.SelectedItem;
            //WATCH STORED PROCEDURE RELATIONSHIP ORDER!!!
            management.Delete(comp.ID);

            RefreshAll();

            MessageBox.Show($"{comp.Name} successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
