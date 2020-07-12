using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    class Job
    {
        DataAccess access = DataAccess.Singleton;

        int id, empID, status, customerProdID;
        string description;
        double cost;
        DateTime scheduledDate;

        public int Id { get => id; set => id = value; }
        public int EmpID { get => empID; set => empID = value; }
        public int Status { get => status; set => status = value; }
        public int CustomerProdID { get => customerProdID; set => customerProdID = value; }
        public string Description { get => description; set => description = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime ScheduledDate { get => scheduledDate; set => scheduledDate = value; }

        public Job()
        {

        }

        public Job(int id, int empID, int status, int customerProdID, string description, double cost, DateTime scheduledDate)
        {
            Id = id;
            EmpID = empID;
            Status = status;
            CustomerProdID = customerProdID;
            Description = description;
            Cost = cost;
            ScheduledDate = scheduledDate;
        }
    }
}
