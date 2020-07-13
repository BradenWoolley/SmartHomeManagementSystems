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
    public partial class TechSupport : UserControl, IValidate
    {
        enum JobStatus { Active = 0, Complete = 1};
        List<Customer> SearchedCustomers = new List<Customer>(), Customers = new List<Customer>();
        string callStarted, callEnded;

        TechManagement management = new TechManagement();

        BindingSource bsJobs = new BindingSource();


        List<Technician> technicians;
        List<Job> jobs;
        List<Technician> hireTechnician;
        List<Job> updateJobs;

        BindingSource bsCustomer = new BindingSource();
        BindingSource bsTechnicians = new BindingSource();
        public TechSupport()
        {
            InitializeComponent();
            dtNewSupport.MinDate = DateTime.Today;
            dtUpdateSupport.MinDate = DateTime.Today;
            PopulateTree();
            RefreshAll();
        }

        void PopulateTree()
        {
            technicians = new Technician().GetTechnicians();
            List<TreeNode> techJobs = new List<TreeNode>();
            
            foreach(var item in technicians)
            {
                TreeNode technician;
                //treeCurrentJobs.Nodes.Add();
                jobs = new Job().GetTechnicianJobs(item.EmpID);

                foreach(var job in jobs)
                {
                    TreeNode t = new TreeNode();
                    t.Text = $"{job.Description}";
                    techJobs.Add(t);
                }
                technician = new TreeNode($"{item.Name} {item.Surname}", techJobs.ToArray());
                treeCurrentJobs.Nodes.Add(technician);
                jobs.Clear();
            }
                

            /*TreeNode active;
            TreeNode Complete;

            List<TreeNode> actives = new List<TreeNode>();
            List<TreeNode> completes = new List<TreeNode>();
            jobs = new Job().GetJobs();
            foreach(var item in jobs)
            {
                if ((JobStatus)item.Status == JobStatus.Active)
                {
                    TreeNode t = new TreeNode();
                    t.Text = $"{item.Description}, {item.";
                    actives.Add(t);
                }

                else
                {
                    TreeNode y = new TreeNode();
                    y.Text = item.Description;
                    completes.Add(y);
                }
                
            }*/

           /* active = new TreeNode("Active", actives.ToArray());
            treeCurrentJobs.Nodes.Add(active);

            Complete = new TreeNode("Complete", completes.ToArray());
            treeCurrentJobs.Nodes.Add(Complete);*/
        }

        #region InterfaceMethods
        public void RefreshAll()
        {
            bsCustomer.Clear();
            Customers.Clear();
            bsJobs.Clear();
            Customers = new Customer().GetCustomers();

            bsCustomer.DataSource = Customers;
            lsBoxClientNames.DataSource = bsCustomer;
            lsBoxClientNames.DisplayMember = "Name";

            lsBoxNewSupport.DataSource = bsCustomer;
            lsBoxNewSupport.DisplayMember = "Name";

            bsTechnicians.Clear();
            hireTechnician = new Technician().GetTechnicians();
            bsTechnicians.DataSource = hireTechnician;

            cbNewSupport.DataSource = bsTechnicians;
            cbNewSupport.DisplayMember = "Name";

            updateJobs = new Job().GetJobs();
            bsJobs.DataSource = updateJobs;

            lsBoxUpdateSupport.DataSource = bsJobs;
            lsBoxUpdateSupport.DisplayMember = "ScheduledDate";

            lsBoxDeleteSupport.DataSource = bsJobs;
            lsBoxDeleteSupport.DisplayMember = "ScheduledDate";

            Job temp = (Job)lsBoxUpdateSupport.SelectedItem;
            if (temp != null)
            {
                txtUpdateCost.Text = temp.Cost.ToString();
                txtUpdateSupportDescription.Text = temp.Description;
                dtUpdateSupport.Value = temp.ScheduledDate;

            }
        }

        public bool IsInRange(ComboBox combo) { return (combo.SelectedIndex >= 0) ? true : false; }
        public bool IsNullOrWhiteSpace(List<MaterialSingleLineTextField> fields)
        {
            //throw new NotImplementedException();
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
        private void btnNewSupport_Click(object sender, EventArgs e)
        {
            List<MaterialSingleLineTextField> fields = new List<MaterialSingleLineTextField>();
            fields.Add(txtDescription);
            if(IsInRange(cbNewSupport) && !IsNullOrWhiteSpace(fields) && lsBoxNewSupport.SelectedIndex > -1 )
            {
                Technician temp = (Technician)cbNewSupport.SelectedItem;
                Customer tempCust = (Customer)lsBoxNewSupport.SelectedItem;

                if(temp != null)
                {
                    management.Insert(temp.EmpID, txtDescription.Text, tempCust.CustomerID, 0, 0, dtNewSupport.Value);
                    MessageBox.Show($"Support Scheduled for {tempCust.Name} {tempCust.Surname} by {temp.Name} {temp.Surname} at {dtNewSupport.Value.Date}");
                    RefreshAll();
                }
            }
        }

        private void btnUpdateSupport_Click(object sender, EventArgs e)
        {
            List<MaterialSingleLineTextField> fields = new List<MaterialSingleLineTextField>();
            List<MaterialSingleLineTextField> numeric = new List<MaterialSingleLineTextField>();
            numeric.Add(txtUpdateCost);
            fields.Add(txtUpdateSupportDescription);
            if (IsInRange(cbUpdateSupport) && !IsNullOrWhiteSpace(fields) && lsBoxUpdateSupport.SelectedIndex > -1 && IsNumeric(numeric))
            {
                Technician temp = (Technician)cbUpdateSupport.SelectedItem;
                Job tempJob = (Job)lsBoxUpdateSupport.SelectedItem;

                if (temp != null)
                {
                    management.Update(tempJob.Id ,temp.EmpID, txtDescription.Text, 0, 0, dtUpdateSupport.Value);
                    MessageBox.Show($"Support updated by {temp.Name} {temp.Surname} at {dtUpdateSupport.Value.Date}");
                    RefreshAll();
                }
            }
        }

        private void BtnDeleteSupport_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure you want to delete this schedule?", "Delete Support", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    if(lsBoxDeleteSupport.SelectedIndex > -1)
                    {
                        Job temp = (Job)lsBoxDeleteSupport.SelectedItem;
                        if (temp != null)
                            management.Delete(temp.Id);
                        RefreshAll();
                    }
                    break;

                default:
                    RefreshAll();
                    break;
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
            management.LogCall(customerCalled.CustomerID, callLogs);

            txtSearchClientName.Clear();
            callEnded = null;
            callStarted = null;

            MessageBox.Show($"Called with {customerCalled.Name} {customerCalled.Surname} ended at {callLogs[1]}", "Called Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
