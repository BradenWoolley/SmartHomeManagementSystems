using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Controller : Component
    {

        DataAccess access = DataAccess.Singleton;

        public Controller() { }
        public Controller(int id, string name, double cost, int type)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Type = 1;
        }

        public List<Controller> GetControllers(int productID)
        {
            List<Controller> controllers = new List<Controller>();

            DataSet rawData = access.ReadComponent("GetComponent",productID, 1);
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
