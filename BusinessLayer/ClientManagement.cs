using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClientManagement
    {
        DataAccess access = DataAccess.Singleton;

        public void Insert(string name, string surname, string email, 
            string address, int phoneNumber, string bankingDetails, double amountDue) => 
            access.NewCustomer(name, surname, email, address, phoneNumber, bankingDetails, amountDue);
        //TODO ~ Implement stored procedure
        public void Delete(int id) => access.Delete("DeleteCustomer", id);

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
