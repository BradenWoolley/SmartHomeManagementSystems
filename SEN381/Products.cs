using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using MaterialSkin.Controls;

namespace SEN381
{
    public partial class Products : UserControl, IBinding, IValidate
    {

        BindingSource bs = new BindingSource();
        BindingSource bsActors = new BindingSource();
        BindingSource bsControllers = new BindingSource();
        BindingSource bsSensors = new BindingSource();
        BindingSource bsComponents = new BindingSource();

        List<Product> catalogue;
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
                txtCost_Update.Text = $"{comp.Cost.ToString("C", CultureInfo.GetCultureInfo("en-ZA"))}";
                cb_ComponentType_Update.SelectedIndex = (comp.Type - 1);
            }

        }

        //Clears and resets all bindingsources
        public void RefreshAll()
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
            RefreshComponents();
        }
        //Clears and resets Actos bindingsources
        public void RefreshActors()
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
        public void RefreshControllers()
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
        public void RefreshSensors()
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
        public void RefreshComponents()
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
        //Insert new component after checking fields ~ TODO move index increment to business layer Implement exception handling
        private void btnSubmitNewProduct_Click(object sender, EventArgs e)
        {
            List<MaterialSingleLineTextField> allFields = NewProductDetails();
            List<MaterialSingleLineTextField> numeric = new List<MaterialSingleLineTextField>();
            numeric.Add(txtCost_Insert);

            if(!IsNullOrWhiteSpace(allFields) && IsNumeric(numeric) && IsInRange(cb_ProductGroup_Insert) && IsInRange(cb_ComponentType_Insert))
            {
                management.Insert(txtComponentName_Insert.Text, cb_ComponentType_Insert.SelectedIndex + 1, double.Parse(txtCost_Insert.Text), product.ProductId);

                RefreshAll();

                MessageBox.Show($"{txtComponentName_Insert.Text} successfully added");
                txtComponentName_Insert.Clear();
                txtCost_Insert.Clear();
            }
        }
        //TODO Correct multi-product group updates and move index increment to business layer Implement exception handling
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<MaterialSingleLineTextField> allFields = UpdateProductDetails();
            List<MaterialSingleLineTextField> numeric = new List<MaterialSingleLineTextField>();

            if (!IsNullOrWhiteSpace(allFields) && IsNumeric(numeric) && IsInRange(cb_ComponentType_Update) 
                && IsInRange(cbProductName_Update) && IsInRange(cbProductGroup_Update))
            {
                BusinessLayer.Component comp = (BusinessLayer.Component)cbProductName_Update.SelectedItem;
                if (comp != null)
                {
                    management.Update(comp.ID, txtComponentName_Update.Text, (cb_ComponentType_Update.SelectedIndex + 1), double.Parse(txtCost_Update.Text), (cbProductGroup_Update.SelectedIndex + 1));
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

        public bool IsNullOrWhiteSpace(List<MaterialSingleLineTextField> fields)
        {
            foreach (var txtBox in fields)
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text.Equals(0))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsNumeric(List<MaterialSingleLineTextField> fields)
        {
            double number;

            foreach (var txtBox in fields)
            {
                if (double.TryParse(txtBox.Text, out number) && txtBox.Text.Length > 0.0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsInRange(ComboBox combo) { return (combo.SelectedIndex >= 0) ? true : false; }

        List<MaterialSingleLineTextField> NewProductDetails()
        {
            List<MaterialSingleLineTextField> fields = new List<MaterialSingleLineTextField>();
            fields.Add(txtComponentName_Insert);
            fields.Add(txtCost_Insert);
            return fields;
        }

        List<MaterialSingleLineTextField> UpdateProductDetails()
        {
            List<MaterialSingleLineTextField> fields = new List<MaterialSingleLineTextField>();
            fields.Add(txtComponentName_Update);
            fields.Add(txtCost_Update);
            return fields;
        }
    }
}
