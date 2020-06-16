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

        public ProductManagement() { }
        //Switch to Lambda
        public void Insert(string name, int componentType, double cost, int productGroup)
        {
            string[] nameParam = new string[2];
            string[] compParam = new string[2];
            string[] costParam = new string[2];
            string[] productParam = new string[2];

            nameParam[0] = "@Name";
            nameParam[1] = name;

            compParam[0] = "@Type";
            compParam[1] = componentType.ToString();

            costParam[0] = "@Cost";
            costParam[1] = cost.ToString();

            productParam[0] = "@ProductID";
            productParam[1] = productGroup.ToString();

            access.Insert("NewComponent", nameParam, compParam, costParam, productParam);
            
        }

        public void Update(int id, string name, int componentType, double cost, int productGroup) => access.Update("UpdateComponent", id, name, componentType, cost, productGroup);

        public void Delete(int id) => access.Delete("DeleteComponent", id);

    }
}
