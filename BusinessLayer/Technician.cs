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

        public List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();

            DataSet rawData = access.ReadProc("GetTechnicians");
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                technicians.Add(new Technician(
                    int.Parse(item["EmpID"].ToString()),
                    item["Name"].ToString(),
                    item["Surname"].ToString()
                    ));
            }
            return technicians;
        }

        public List<Technician> GetActiveTechnicians()
        {
            List<Technician> technicians = new List<Technician>();

            DataSet rawData = access.ReadProc("GetTechnicians");
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                technicians.Add(new Technician(
                    int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    item["Surname"].ToString()
                    ));
            }
            return technicians;
        }

    }
}
