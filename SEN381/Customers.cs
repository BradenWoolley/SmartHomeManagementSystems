using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using MaterialSkin.Controls;

namespace SEN381
{
    public partial class Customers : UserControl, IBinding, IValidate
    {

        BindingSource bs = new BindingSource();
        //Owned binding sources
        BindingSource bsActors = new BindingSource();
        BindingSource bsControllers = new BindingSource();
        BindingSource bsSensors = new BindingSource();
        BindingSource bsComponents = new BindingSource();
        BindingSource bsProducts = new BindingSource();
        //Unowned binding sources
        BindingSource bsProductList = new BindingSource();
        BindingSource bsActorsList = new BindingSource();
        BindingSource bsControllersList = new BindingSource();
        BindingSource bsSensorsList = new BindingSource();
        BindingSource bsComponentsList = new BindingSource();

        //owned lists
        List<Customer> customers;
        List<Actor> actors = new List<Actor>();
        List<Controller> controllers = new List<Controller>();
        List<Sensor> sensors = new List<Sensor>();
        List<Product> products = new List<Product>();

        //Unowned lists
        List<Product> catalogue = new List<Product>();
        List<Actor> unownedActors = new List<Actor>();
        List<Controller> unownedControllers = new List<Controller>();
        List<Sensor> unownedSensors = new List<Sensor>();
        Product product;
        //List<Product> ownedProducts = new List<Product>();

        ClientManagement management = new ClientManagement();

        Customer customer;
        public Customers()
        {
            InitializeComponent();
            RefreshAll();
        }

        public void RefreshAll()
        {
            bs.Clear();
            customers = new Customer().GetCustomers();
            bs.DataSource = customers;
            dgView_Customers.DataSource = bs;

            cbUpdateCustomer.DataSource = bs;
            cbUpdateCustomer.DisplayMember = "Name";

            cbDeleteCustomer.DataSource = bs;
            cbDeleteCustomer.DisplayMember = "Name";

            bsProductList.Clear();
            catalogue = new Product().GetProducts();
            bsProductList.DataSource = catalogue;
            //cbNewProductName.DataSource = bsProductList;
            //cbNewProductName.DisplayMember = "ProductSuite";
            //product = (Product)cbNewProductName.SelectedItem;

            RefreshOwnedProducts();
            RefreshAllProducts();
        }

        public void RefreshComponents()
        {
            /*bsComponents.Clear();


            if (customer != null)
            {
                List<BusinessLayer.Component> components = new List<BusinessLayer.Component>();
                components.Clear();

                components = new BusinessLayer.Component().GetComponents();

                bsComponents.DataSource = components;

                cbProductName_Update.DataSource = bsComponents;
                cbProductName_Update.DisplayMember = "Name";

                cbProductName_Delete.DataSource = bsComponents;
                cbProductName_Delete.DisplayMember = "Name";
                }*/
        }

        public void RefreshActors()
        {
            bsActors.Clear();
            actors.Clear();

            if (customer != null)
            {
                actors = new Actor().GetCustomerActors(customer.CustomerID);
                bsActors.DataSource = actors;
                dgView_Actors.DataSource = bsActors;
            }



        }

        public void RefreshPurchaseActors()
        {
           /*bsActorsList.Clear();
            unownedActors.Clear();

            //bsProductList.Clear();

            product = (Product)bsProductList.Current;

            if (product != null)
            {
                unownedActors = new Actor().GetActors(product.ProductId);
                bsActorsList.DataSource = unownedActors;
                cbNewActors.DataSource = bsActorsList;
                cbNewActors.DisplayMember = "Name";
            }*/
        }

        public void RefreshControllers()
        {
            bsControllers.Clear();
            controllers.Clear();

            if (customer != null)
            {
                controllers = new Controller().GetCustomerControllers(customer.CustomerID);
                bsControllers.DataSource = controllers;
                dgView_Controllers.DataSource = bsControllers;
            }
        }

        public void RefreshSensors()
        {
            bsSensors.Clear();
            sensors.Clear();

            if (customer != null)
            {
                sensors = new Sensor().GetCustomerSensors(customer.CustomerID);
                bsSensors.DataSource = sensors;
                dgView_Sensors.DataSource = bsSensors;
            }
        }

        void RefreshProducts()
        {

            bsProducts.Clear();
            products.Clear();

            customer = (Customer)bs.Current;

            if (customer != null)
            {
                products = new Product().GetCustomerProducts(customer.CustomerID);
                bsProducts.DataSource = products;
                lsBox_products.DataSource = bsProducts;
                lsBox_products.DisplayMember = "ProductSuite";
            }
        }

        void RefreshOwnedProducts()
        {
            RefreshProducts();
            RefreshActors();
            RefreshControllers();
            RefreshSensors();
        }

        void RefreshAllProducts()
        {
            RefreshPurchaseActors();
        }

        private void dgView_Customers_Click(object sender, EventArgs e) => RefreshOwnedProducts();

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer temp = (Customer)cbUpdateCustomer.SelectedItem;

            if (temp != null)
            {
                txtUpdateName.Text = temp.Name;
                txtUpdateSurname.Text = temp.Surname;
                txtUpdateEmail.Text = temp.Email;
                txtUpdateAddress.Text = temp.Address;
                txtUpdateTelephone.Text = temp.PhoneNumber.ToString();
                txtUpdateBank.Text = temp.BankingDetails;
            }
        }
        private void lsBox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshActors();
            RefreshControllers();
            RefreshSensors();
        }

        //TODO ~ Add products to new Customer update stored procedure to use scope_identity
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            List<MaterialSingleLineTextField> allFields = NewCustomerDetails();
            List<MaterialSingleLineTextField> numericFields = new List<MaterialSingleLineTextField>();
            numericFields.Add(txtNewPhone);

            if (!IsNullOrWhiteSpace(allFields) && IsNumeric(numericFields))
            {
                management.Insert(txtNewName.Text, txtNewSurname.Text, txtNewEmail.Text, txtNewAddress.Text, int.Parse(txtNewPhone.Text), txtNewBankAccount.Text, 0);
                MessageBox.Show("Insertion successful!");
                RefreshAll();
                ClearFields(allFields);
            }

            else
            {
                MessageBox.Show("Vaules in incorrect format");
            }

        }
        //TODO ~ Add functionality
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer temp = (Customer)cbDeleteCustomer.SelectedItem;
            management.Delete(temp.CustomerID);
            MessageBox.Show("Deletion successful!");
            RefreshAll();
        }

        List<MaterialSingleLineTextField> NewCustomerDetails()
        {
            List<MaterialSingleLineTextField> fields = new List<MaterialSingleLineTextField>();
            fields.Add(txtNewName);
            fields.Add(txtNewSurname);
            fields.Add(txtNewEmail);
            fields.Add(txtNewAddress);
            fields.Add(txtNewPhone);
            fields.Add(txtNewBankAccount);

            return fields;
        }

        void ClearFields(List<MaterialSingleLineTextField> fields)
        {
            foreach (var txtBox in fields)
            {
                txtBox.Clear();
            }
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
            int number;

            foreach (var txtBox in fields)
            {
                if (int.TryParse(txtBox.Text, out number) && txtBox.Text.Length.Equals(10) && int.Parse(txtBox.Text.ToString()) > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsInRange(ComboBox combo){return (combo.SelectedIndex >= 0) ? true : false;}

        private void cbNewProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAllProducts();
        }
    }

}
