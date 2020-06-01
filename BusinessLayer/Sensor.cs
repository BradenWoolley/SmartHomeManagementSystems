using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Sensor : Component
    {
        DataAccess access = DataAccess.Singleton;

        public Sensor() { }
        public Sensor(int id, string name, double cost, int type)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Type = 2;
        }

        public List<Sensor> GetSensors(int productID)
        {
            List<Sensor> sensors = new List<Sensor>();

            DataSet rawData = access.ReadComponent("GetComponent", productID, 2);
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                sensors.Add(new Sensor(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    double.Parse(item["Cost"].ToString()),
                    this.Type
                    ));
            }
            return sensors;
        }
    }
}
