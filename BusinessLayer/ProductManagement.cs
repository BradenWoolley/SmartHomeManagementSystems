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
        DataAccess access = DataAccess.Singleton;

        public ProductManagement()
        {

        }

        public void Insert(string name, int componentType, double cost, int productGroup)
        {
            access.Insert(name, componentType, cost, productGroup);
        }

        public void Update(int id, string name, int componentType, double cost, int productGroup)
        {
            access.Update("UpdateComponent", id, name, componentType, cost, productGroup);
        }

        public void Delete(int id)
        {
            access.Delete("DeleteComponent", id);
        }

    }
}
