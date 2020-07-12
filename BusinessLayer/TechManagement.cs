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

        //public void Insert() { }
        //public void Update() { }
        //public void Delete() { }
    }
}
