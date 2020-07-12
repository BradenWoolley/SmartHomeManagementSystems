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
using BusinessLayer;

namespace SEN381
{
    public partial class TechSupport : UserControl, IBinding, IValidate
    {
        List<Customer> SearchedCustomers = new List<Customer>(), Customers;
        string callStarted, callEnded;

        TechnologySupport tech = new TechnologySupport();

        BindingSource bsCustomer = new BindingSource();
        public TechSupport()
        {
            InitializeComponent();

            RefreshAll();
        }

        #region InterfaceMethods
        public void RefreshActors()
        {
            //throw new NotImplementedException();
        }
        public void RefreshAll()
        {
            bsCustomer.Clear();
            Customers = new Customer().GetCustomers();
            bsCustomer.DataSource = Customers;
            lsBoxClientNames.DataSource = bsCustomer;
            lsBoxClientNames.DisplayMember = "Name";
        }
        public void RefreshComponents()
        {
            //throw new NotImplementedException();
        }
        public void RefreshControllers()
        {
            //throw new NotImplementedException();
        }
        public void RefreshSensors()
        {
            //throw new NotImplementedException();
        }
        public bool IsInRange(ComboBox combo)
        {
            //throw new NotImplementedException();
            return true;
        }
        public bool IsNullOrWhiteSpace(List<MaterialSingleLineTextField> fields)
        {
            //throw new NotImplementedException();
            return false;
        }
        public bool IsNumeric(List<MaterialSingleLineTextField> fields)
        {
            //throw new NotImplementedException();
            return true;
        }

        #endregion

        //Filters listbox for similar names to call
        private void txtSearchClientName_TextChanged(object sender, EventArgs e)
        {
            SearchedCustomers.Clear();
            string searchValue = txtSearchClientName.Text;
            if (String.IsNullOrEmpty(searchValue))
            {
                SearchedCustomers.Clear();
                lsBoxClientNames.DataSource = bsCustomer;
            }

            else
            {
                foreach (var customer in Customers)
                {
                    if (customer.Name.Contains(searchValue))
                    {
                        SearchedCustomers.Add(customer);
                    }
                }

                lsBoxClientNames.DataSource = SearchedCustomers;
            }
        }

        private void btn_Call_Click(object sender, EventArgs e) 
        {
            Customer cus = (Customer)lsBoxClientNames.SelectedItem;
            txtSearchClientName.Text = cus.Name;
            callStarted = DateTime.Now.ToLocalTime().ToString();
        } 

        private void btn_EndCall_Click(object sender, EventArgs e)
        {
            if (callStarted == null)
                return;


            callEnded = DateTime.Now.ToLocalTime().ToString();

            string[] callLogs = new string[2];

            callLogs[0] = callStarted;
            callLogs[1] = callEnded;

            Customer customerCalled = (Customer)lsBoxClientNames.SelectedItem;

            string name = customerCalled.Name;
            tech.LogCall(customerCalled.CustomerID, callLogs);

            txtSearchClientName.Clear();

            MessageBox.Show($"Called with {customerCalled.Name} {customerCalled.Surname} ended at {callLogs[1]}", "Called Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
