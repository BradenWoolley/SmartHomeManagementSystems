using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    enum ComponentTypes
    {
        Controller = 1,
        Sensor = 2,
        Actor = 3
    }
    public class ProductCatalogue : Product
    {
        private List<Sensor> productSensors;
        private List<Actor> productActors;
        private List<Controller> productControllers;

        public ProductCatalogue() { }

        public ProductCatalogue(int productID, string productSuite, List<Sensor> productSensors, List<Actor> productActors, List<Controller> productControllers)
        {
            ProductId = productID;
            ProductSuite = productSuite;
            ProductSensors = productSensors;
            ProductActors = productActors;
            ProductControllers = productControllers;
        }

        public List<Sensor> ProductSensors { get => productSensors; set => productSensors = value; }
        public List<Actor> ProductActors { get => productActors; set => productActors = value; }
        public List<Controller> ProductControllers { get => productControllers; set => productControllers = value; }

        public List<ProductCatalogue> GetCatalogue()
        {
            List<ProductCatalogue> productCatalogues = new List<ProductCatalogue>();

            //DataAccess dataAccess = new DataAccess();
            // DataSet productRawData = dataAccess.ReadAllProducts();
            List<Product> product = new Product().GetProducts();
            List<Actor> actors = new List<Actor>();
            List<Controller> controllers = new List<Controller>();
            List<Sensor> sensors = new List<Sensor>();

            foreach (var prod in product)
            {
                DataSet rawData = new DataAccess().ReadData("tblProductComponents");

                foreach (DataRow item in rawData.Tables["tblProductComponents"].Rows)
                {
                    if (int.Parse(item["ProductID"].ToString()) == prod.ProductId)
                    {
                        List<Component> components = new Component().GetComponents();

                        foreach (var comp in components)
                        {
                            if (comp.ID == int.Parse(item["ComponentID"].ToString()))
                            {
                                switch ((ComponentTypes)int.Parse(comp.Type.ToString()))
                                {
                                    case ComponentTypes.Controller:
                                        controllers.Add(new Controller(comp.ID, comp.Name, comp.Cost));
                                        break;

                                    case ComponentTypes.Sensor:
                                        sensors.Add(new Sensor(comp.ID, comp.Name, comp.Cost));
                                        break;

                                    case ComponentTypes.Actor:
                                        actors.Add(new Actor(comp.ID, comp.Name, comp.Cost));
                                        break;

                                    default:
                                        string debug = comp.Type.ToString();
                                        break;
                                }
                            }
                        }//end of component loop
                    }
                }//end of productcomponent loop
                productCatalogues.Add(new ProductCatalogue(prod.ProductId, prod.ProductSuite, sensors, actors, controllers));
            }
            return productCatalogues;
        }
    }
}
