using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Actor : Component
    {

        DataAccess access = DataAccess.Singleton;

        public Actor() { }
        public Actor(int id, string name, double cost, int type)
        {
            ID = id;
            Name = name;
            Cost = cost;
            Type = 3;
        }

        public List<Actor> GetActors(int productID)
        {
            List<Actor> actors = new List<Actor>();

            DataSet rawData = access.ReadComponent("GetComponent",productID, 3);
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                actors.Add(new Actor(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    double.Parse(item["Cost"].ToString()),
                    this.Type
                    ));
            }
            return actors;
        }

        public List<Actor> GetCustomerActors(int customerID)
        {
            List<Actor> actors = new List<Actor>();

            DataSet rawData = access.ReadData("GetCustomerComponents", customerID, 3);
            
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                actors.Add(new Actor(int.Parse(item["ID"].ToString()),
                    item["Name"].ToString(),
                    double.Parse(item["Cost"].ToString()),
                    this.Type
                    ));
            }
            return actors;
        }
    }
}
