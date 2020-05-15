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
        public Actor(int id, string name, double cost/*, int type*/)
        {
            ID = id;
            Name = name;
            Cost = cost;
            //Type = type;
        }

        public List<Actor> GetActors()
        {
            List<Actor> actors = new List<Actor>();
            DataSet rawData = new DataAccess().ReadData("tblComponent", "3");
            foreach (DataRow item in rawData.Tables["tblComponent"].Rows)
            {
                actors.Add(new Actor(int.Parse(item["ID"].ToString()), item["Name"].ToString(), double.Parse(item["Cost"].ToString())/*, int.Parse(item["Type"].ToString())*/));
            }
            return actors;
        }

        public List<Actor> GetActors(int productID)
        {
            List<Actor> actors = new List<Actor>();

            DataSet rawData = new DataAccess().ReadComponent("GetComponent",productID, 3);
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                actors.Add(new Actor(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(), 
                    double.Parse(item["Cost"].ToString())/*,
                    int.Parse(item["ComponentType"].ToString())*/));
            }
            return actors;
        }
    }
}
