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
        BindingSource bs = new BindingSource();

        List<Customer> customers;
        Customer customer;
        public Customers()
        {
            InitializeComponent();
            customers = new Customer().GetCustomers();
            bs.DataSource = customers;
            dgView_Customers.DataSource = bs;
        }
    }
}
