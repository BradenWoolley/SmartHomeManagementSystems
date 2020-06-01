using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Controller : Component
    {
        public Controller() { }
        public Controller(int id, string name, double cost, int type)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Type = 1;
        }

        /*public List<Controller> GetControllers()
        {
            List<Controller> controllers = new List<Controller>();
            DataSet rawData = new DataAccess().ReadData("tblComponent", "1");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                controllers.Add(new Controller(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())));
            }
            return controllers;
        }*/

        public List<Controller> GetControllers(int productID)
        {
            List<Controller> controllers = new List<Controller>();

            DataSet rawData = new DataAccess().ReadComponent("GetComponent",productID, 1);
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                controllers.Add(new Controller(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    double.Parse(item["Cost"].ToString()),
                    this.Type
                    ));
            }
            return controllers;
        }
    }
}
