using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Component
    {
        private int id;
        private string name;
        private double cost;
        //private int type;

        public Component() { }

        public Component(int id, string name, double cost)
        {
            ID = id;
            Name = name;
            Cost = cost;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }

        public List<Component> GetComponents()
        {
            List<Component> components = new List<Component>();
            DataSet rawData = new DataAccess().ReadData("tblComponent");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                components.Add(new Component(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())));
            }
            return components;
        }
    }
}
