using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Technician : Customer
    {
        DataAccess access = DataAccess.Singleton;
        int empID;
        public int EmpID { get => empID; set => empID = value; }
        public Technician() { }

        public Technician(int empID, string name, string surname)
        {
            EmpID = empID;
            Name = name;
            Surname = surname;
        }

        
    }
}
