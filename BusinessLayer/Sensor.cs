using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Sensor : Component
    {
        public Sensor() { }
        public Sensor(int id, string name, double cost, int type)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Type = type;
        }

        /*public List<Sensor> GetSensors()
        {
            List<Sensor> sensors = new List<Sensor>();
            DataSet rawData = new DataAccess().ReadData("tblComponent", "2");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                sensors.Add(new Sensor(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())));
            }
            return sensors;
        }*/

        public List<Sensor> GetSensors(int productID)
        {
            List<Sensor> sensors = new List<Sensor>();

            DataSet rawData = new DataAccess().ReadComponent("GetComponent", productID, 2);
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
