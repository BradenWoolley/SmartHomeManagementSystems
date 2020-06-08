using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SEN381
{
    public partial class Customers : UserControl, IBinding
    {
        BindingSource bs = new BindingSource();

        BindingSource bsActors = new BindingSource();
        BindingSource bsControllers = new BindingSource();
        BindingSource bsSensors = new BindingSource();
        BindingSource bsComponents = new BindingSource();
        BindingSource bsProducts = new BindingSource();

        List<Customer> customers;
        List<Actor> actors = new List<Actor>();
        List<Controller> controllers = new List<Controller>();
        List<Sensor> sensors = new List<Sensor>();
        List<Product> products = new List<Product>();

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
        }

        public void RefreshComponents()
        {
            /* bsComponents.Clear();


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

        private void dgView_Customers_Click(object sender, EventArgs e)
        {
            RefreshProducts();
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
    }

}
