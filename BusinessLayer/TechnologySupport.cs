using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TechnologySupport
    {
        DataAccess access = DataAccess.Singleton;

        private int customerID;
        //private List<string> configuration;
        private double cost;
        private DateTime scheduledDate;

        public delegate void OnSchedule();

        //Will send email to client informing them of their scheduled maintenance details
        public event OnSchedule onSchedule;
        public TechnologySupport() { }
        public TechnologySupport(int customerID, /*List<string> configuration,*/ DateTime scheduledDate)
        {
            CustomerID = customerID;
            //Configuration = configuration;
            Cost = cost;
            ScheduledDate = scheduledDate;
        }

        public int CustomerID { get => customerID; set => customerID = value; }
        //public List<string> Configuration { get => configuration; set => configuration = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime ScheduledDate { get => scheduledDate; set => scheduledDate = value; }

        //Potentially remove
        private double GetCost()
        {
            //Would use configuration and ProductCatalogue to get price of components to replace

            //else DB will contain a list of repair/installation prices

            //Can be use event to update customer AmountDue
            return cost;
        }
    }
}
