using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ProductManagement
    {
        DataAccess access;


        public void Insert(string name, int componentType, double cost, int productGroup)
        {
            access = new DataAccess();
            access.Insert(name, componentType, cost, productGroup);
        }

        public void Update(int id, string name)
        {
            
        }

        public void Delete(int id)
        {
            access = new DataAccess();
            access.Delete("DeleteComponent", id);
        }

    }
}
