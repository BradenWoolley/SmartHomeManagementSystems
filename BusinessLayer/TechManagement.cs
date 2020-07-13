using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TechManagement
    {
        DataAccess access = DataAccess.Singleton;
        public void LogCall(int custID, string[] callLogs) => access.LogCall(custID, callLogs, "LogCalls");

        public void Insert(int empID, string description, int customerID,
            int jobStatus, double cost, DateTime date) => 
            access.ScheduleSupport(empID, description, customerID, jobStatus, cost, date);

        public void Update(int jobID, int empID, string description,
            int jobStatus, double cost, DateTime date) =>
             access.UpdateSupport(jobID, empID, description, jobStatus, cost, date);
        public void Delete(int jobID) => access.Delete("DeleteSupport", jobID);
    }
}
