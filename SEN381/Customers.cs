using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace SEN381
{
    public partial class Customers : UserControl
    {
        BindingSource bs;

        List<Customer> customers;
        public Customers()
        {
            InitializeComponent();
            //customers = new ClientManagement().ViewAllCustomers();
            //bs.DataSource = customers;
            dgView_Customer.DataSource = bs;
        }
    }
}
