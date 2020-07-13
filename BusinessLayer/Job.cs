using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Job
    {
        DataAccess access = DataAccess.Singleton;

        int id, empID, status, customerID;
        string description;
        double cost;
        DateTime scheduledDate;

        public int Id { get => id; set => id = value; }
        public int EmpID { get => empID; set => empID = value; }
        public int Status { get => status; set => status = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public string Description { get => description; set => description = value; }
        public double Cost { get => cost; set => cost = value; }
        public DateTime ScheduledDate { get => scheduledDate; set => scheduledDate = value; }

        public Job()
        {

        }

        public Job(int id, string description, int empID, int status, int customerID,  double cost/*, DateTime scheduledDate*/)
        {
            Id = id;
            Description = description;
            EmpID = empID;
            Status = status;
            CustomerID = customerID; 
            Cost = cost;
            ScheduledDate = scheduledDate;
        }
        public Job(int id, string description, int empID, int status, int customerID, double cost, DateTime scheduledDate)
        {
            Id = id;
            Description = description;
            EmpID = empID;
            Status = status;
            CustomerID = customerID;
            Cost = cost;
            ScheduledDate = scheduledDate;
        }

        public Job(int id, string description, /*int empID, */int status, /*int customerProdID, */double cost/*, DateTime scheduledDate*/)
        {
            Id = id;
            Description = description;
            //EmpID = empID;
            Status = status;
            //CustomerProdID = customerProdID;
            Cost = cost;
            //ScheduledDate = scheduledDate;
        }
        public Job(int id, string description, /*int empID, */int status /*int customerProdID,/double cost, DateTime scheduledDate*/)
        {
            Id = id;
            Description = description;
            //EmpID = empID;
            Status = status;
            //CustomerProdID = customerProdID;
            //Cost = cost;
            //ScheduledDate = scheduledDate;
        }

        public List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>();

            DataSet rawData = access.ReadProc("GetJobs");

            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                jobs.Add(new Job(int.Parse(item["ID"].ToString()),
                    item["JobDescription"].ToString(),
                    int.Parse(item["EmpID"].ToString()),
                    int.Parse(item["JobStatus"].ToString()),
                    int.Parse(item["CustomerID"].ToString()),
                    double.Parse(item["Cost"].ToString()),
                    DateTime.Parse(item["Date"].ToString())
                    ));
            }
            return jobs;
        }

        public List<Job> GetTechnicianJobs(int technicianID)
        {
            List<Job> jobs = new List<Job>();

            DataSet rawData = access.ReadTechnicianJobs("GetTechJobs", technicianID);

            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                jobs.Add(new Job(int.Parse(item["ID"].ToString()),
                    item["JobDescription"].ToString(),
                    /*int.Parse(item["EmpID"].ToString()),*/
                    int.Parse(item["JobStatus"].ToString())
                    /*int.Parse(item["CustomerProductID"].ToString()),
                    double.Parse(item["Cost"].ToString())/*,
                    DateTime.Parse(item["Date"].ToString())*/
                    ));
            }
            return jobs;
        }
    }
}
