using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Product
    {
        DataAccess access = DataAccess.Singleton;

        private int productId;
        private string productSuite;

        public Product() { }
        public Product(int productId, string productSuite)
        {
            ProductId = productId;
            ProductSuite = productSuite;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductSuite { get => productSuite; set => productSuite = value; }

        //TODO GetProducts
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            DataSet rawData = access.ReadData("tblProductCatalogue");
            foreach (DataRow item in rawData.Tables["tblProductCatalogue"].Rows)
            {
                products.Add(new Product(int.Parse(item["ID"].ToString()), item["ProductSuite"].ToString()));
            }

            return products;
        }

        public List<Product> GetCustomerProducts(int customerID)
        {
            List<Product> products = new List<Product>();
            DataSet rawData = access.ReadProc("GetCustomerProducts", customerID);
            foreach (DataRow item in rawData.Tables["Table"].Rows)
            {
                products.Add(new Product(int.Parse(item["ID"].ToString()), item["ProductSuite"].ToString()));
            }

            return products;
        }
    }
}
