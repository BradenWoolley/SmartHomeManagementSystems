using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Customer
    {
        DataAccess access = DataAccess.Singleton;

        private int customerID, phoneNumber, productCount;

        private string name, surname, email, address;

        private DateTime billingDate;

        private string bankingDetails;

        private double amountDue;

        private List<Actor> ownedActors;
        private List<Sensor> ownedSensors;
        private List<Controller> ownedControllers;

        public int CustomerID { get => customerID; set => customerID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime BillingDate { get => billingDate; set => billingDate = value; }
        public string BankingDetails { get => bankingDetails; set => bankingDetails = value; }
        public double AmountDue { get => amountDue; set => amountDue = value; }
        internal List<Actor> OwnedActors { get => ownedActors; set => ownedActors = value; }
        internal List<Sensor> OwnedSensors { get => ownedSensors; set => ownedSensors = value; }
        internal List<Controller> OwnedControllers { get => ownedControllers; set => ownedControllers = value; }
        public int ProductCount { get => productCount; set => productCount = value; }

        //Default Constructor
        public Customer() { }

        public Customer(int customerID, string name, string surname, string email, string address, int phoneNumber
            , string bankingDetails, double amountDue)
        {
            CustomerID = customerID;
            Name = name;
            Surname = surname;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            BillingDate = billingDate;
            BankingDetails = bankingDetails;
            AmountDue = amountDue;
        }

        public Customer(int customerID, string name, string surname, string email, string address, int phoneNumber
            , string bankingDetails, double amountDue, int productCount, List<Actor> ownedActors, List<Sensor> ownedSensors, List<Controller> ownedControllers)
        {
            CustomerID = customerID;
            Name = name;
            Surname = surname;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            BillingDate = billingDate;
            BankingDetails = bankingDetails;
            AmountDue = amountDue;
            ProductCount = productCount;
            OwnedActors = ownedActors;
            OwnedSensors = ownedSensors;
            OwnedControllers = ownedControllers;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            DataSet rawData = access.ReadProc("GetCustomers");
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                customers.Add(new Customer(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    item["Surname"].ToString(),
                    item["Email"].ToString(),
                    item["Address"].ToString(),
                    int.Parse(item["Telephone"].ToString()),
                    item["BankingDetails"].ToString(),
                    double.Parse(item["AmountDue"].ToString())
                    ));
            }
            return customers;
        }
    }
}
