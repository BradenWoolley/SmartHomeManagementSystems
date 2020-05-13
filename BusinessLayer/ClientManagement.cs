using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClientManagement
    {
        /*public List<Customer> ViewAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();

            DataAccess dataAccess = new DataAccess();
            DataSet productRawData = dataAccess.ReadAllCustomers();

            //Gets productsuite to find all components, sensors, and actors needed
            foreach (DataRow item in productRawData.Tables["tblProductCatalogue"].Rows)
            {
                customer.CustomerID = int.Parse(item["CustomerID"].ToString());
                customer.Name = item["Name"].ToString();
                customer.Surname = item["Surname"].ToString();
                customer.Email = item["Email"].ToString();
                customer.Address = item["Address"].ToString();
                customer.PhoneNumber = int.Parse(item["Telephone"].ToString());
                customer.BankingDetails = item["BankingDetails"].ToString();
                customer.AmountDue = int.Parse(item["AmountDue"].ToString());

                switch ((ComponentTypes)int.Parse(item["ComponentType"].ToString()))
                {
                    case ComponentTypes.Controller:
                        Controller controller = new Controller(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                        customer.OwnedControllers.Add(controller);
                        break;

                    case ComponentTypes.Sensor:
                        Sensor sensor = new Sensor(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                        customer.OwnedSensors.Add(sensor);
                        break;

                    case ComponentTypes.Actor:
                        Actor actor = new Actor(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                        customer.OwnedActors.Add(actor);
                        break;

                    default:
                        //TODO add exception
                        break;
                }

                customers.Add(customer);
            }


            return customers;
        }*/

        List<TechnologySupport> GetAllSupport()
        {
            List<TechnologySupport> customerSupport = new List<TechnologySupport>();
            TechnologySupport techSupport = new TechnologySupport();

            DataAccess dataAccess = new DataAccess();
            DataSet productRawData = dataAccess.ReadAllTechSupport();

            //Gets productsuite to find all components, sensors, and actors needed
            foreach (DataRow item in productRawData.Tables["tblTechSupport"].Rows)
            {
                techSupport.CustomerID = int.Parse(item["CustomerID"].ToString());
                techSupport.ScheduledDate = DateTime.Parse(item["ScheduledDate"].ToString());

                techSupport.Cost = double.Parse(item["Cost"].ToString());

                //TODO Database needs to be edited to access Client configuration and account for changes made
                //techSupport.Configuration = 

                /*switch ((ComponentTypes)int.Parse(item["ComponentType"].ToString()))
                {
                    case ComponentTypes.Controller:
                        
                        break;

                    case ComponentTypes.Sensor:
                       
                        break;

                    case ComponentTypes.Actor:
                        
                        break;

                    default:
                        //TODO add exception
                        break;
                }*/

                customerSupport.Add(techSupport);
            }
            return customerSupport;
        }

        /* List<Customer> SearchCustomer(CustomerID, Or Name)
        {
            return;
        }*/

        public void AddNewCustomer(string fName, string sName)
        {

        }

        public void EditCustomerDetails()
        {

        }

        public void EditCustomerProduct()
        {

        }

        public void ScheduleTechSupport(/*all necessary fields of the TechSupport Constructors*/)
        {

        }
        public void BillCustomer()
        {
            //Bill customer when Billing date = Current Date
            //Implement Emailed Bill to customer
        }
    }
}
