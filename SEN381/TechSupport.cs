using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BusinessLayer;

namespace SEN381
{
    public partial class TechSupport : UserControl, IBinding, IValidate
    {
        List<Customer> SearchedCustomers = new List<Customer>(), Customers = new List<Customer>();
        string callStarted, callEnded;

        TechManagement tech = new TechManagement();

        BindingSource bsCustomer = new BindingSource();
        public TechSupport()
        {
            InitializeComponent();

            RefreshAll();

            //TODO ~ Refactor to own method
            TreeNode parentNode = new TreeNode("Volim");
            treeCurrentJobs.Nodes.Add(parentNode);    
            TreeNode childNode1 = new TreeNode("Guzu");
            //TreeNode childNode2= new TreeNode("Makyu");
            TreeNode[] childNodes = new TreeNode[] { childNode1/*, childNode2*/ };
            parentNode = new TreeNode("Anjinu", childNodes);
            treeCurrentJobs.Nodes.Add(parentNode);
        }

        #region InterfaceMethods
        public void RefreshActors()
        {
            //throw new NotImplementedException();
        }
        public void RefreshAll()
        {
            bsCustomer.Clear();
            Customers.Clear();
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
                    if (customer.Name.ToLower().Contains(searchValue.ToLower()))
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
            callEnded = null;
            callStarted = null;

            MessageBox.Show($"Called with {customerCalled.Name} {customerCalled.Surname} ended at {callLogs[1]}", "Called Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
