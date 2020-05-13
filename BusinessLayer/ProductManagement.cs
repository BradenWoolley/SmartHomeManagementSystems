using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManagement
    {
        public void AddNewProduct()
        {

        }

        public void ViewAllProducts()
        {
            //TODO replace all string values with their appropriate SQL Table.ColumnName

        }

        public void EditProductDetials()
        {

        }

        //Take type as parameter to be able to edit sensors, controllers, or actors
        public void AddNewComponent()
        {

        }

        public void EditComponents()
        {

        }

        /* public List<ProductCatalogue> SearchProduct()
         {
             List<ProductCatalogue> productCatalogues = new List<ProductCatalogue>();
             ProductCatalogue productCatalogue = new ProductCatalogue();

             DataAccess dataAccess = new DataAccess();
             DataSet productRawData = dataAccess.ReadAllProducts();

             //Gets productsuite to find all components, sensors, and actors needed
             foreach (DataRow item in productRawData.Tables["tblProductCatalogue"].Rows)
             {
                 productCatalogue.ProductId = int.Parse(item["ProductID"].ToString());
                 productCatalogue.ProductSuite = item["ProductSuite"].ToString();

                 switch ((ComponentTypes)int.Parse(item["ComponentType"].ToString()))
                 {
                     case ComponentTypes.Controller:
                         Controller controller = new Controller(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                         productCatalogue.ProductControllers.Add(controller);
                         break;

                     case ComponentTypes.Sensor:
                         Sensor sensor = new Sensor(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                         productCatalogue.ProductSensors.Add(sensor);
                         break;

                     case ComponentTypes.Actor:
                         Actor actor = new Actor(int.Parse(item["ComponentID"].ToString()), item["Name"].ToString(), 0);
                         productCatalogue.ProductActors.Add(actor);
                         break;

                     default:
                         //TODO add exception
                         break;
                 }

                 productCatalogues.Add(productCatalogue);
             }

             return productCatalogues;
         }*/
    }
}
