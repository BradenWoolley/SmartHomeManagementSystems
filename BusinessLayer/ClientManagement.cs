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

        public void Insert(int customerID, Product product, Component component)
        {
            string serial = component.Type + component.Name + component.ID;

            access.AddOrder("NewCustomerProduct", customerID, product.ProductId, component.ID, serial);
        }

        public void Update(int id, string name, string surname, string email,
            string address, string phoneNumber, string bankingDetails) =>
            access.Update(id, name, surname, email,
             address, phoneNumber, bankingDetails);

        public void Delete(int id) => access.Delete("DeleteCustomer", id);
    }
}
