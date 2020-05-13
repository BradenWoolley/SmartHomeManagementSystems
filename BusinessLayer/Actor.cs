using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Actor : Component
    {
        public Actor() { }
        public Actor(int id, string name, double cost)
        {
            ID = id;
            Name = name;
            Cost = cost;
        }

        public List<Actor> GetActors()
        {
            List<Actor> actors = new List<Actor>();
            DataSet rawData = new DataAccess().ReadData("tblComponent", "3");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                actors.Add(new Actor(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())));
            }
            return actors;
        }
    }
}
