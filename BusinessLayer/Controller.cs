using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Controller : Component
    {
        public Controller() { }
        public Controller(int id, string name, double cost)
        {
            ID = id;
            Name = name;
            Cost = cost;
        }

        public List<Controller> GetControllers()
        {
            List<Controller> controllers = new List<Controller>();
            DataSet rawData = new DataAccess().ReadData("tblComponent", "1");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                controllers.Add(new Controller(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())));
            }
            return controllers;
        }
    }
}
