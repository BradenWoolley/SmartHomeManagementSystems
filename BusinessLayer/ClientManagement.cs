using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClientManagement
    {
        DataAccess access = DataAccess.Singleton;

        public void AddNewCustomer(string fName, string sName)
        {

        }

        public void EditCustomerDetails()
        {

        }

        public void EditCustomerProduct()
        {

        }

        public void BillCustomer()
        {
            //Bill customer when Billing date = Current Date
            //Implement Emailed Bill to customer
        }
    }
}
