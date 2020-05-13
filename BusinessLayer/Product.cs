using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Product
    {
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
            DataSet rawData = new DataAccess().ReadData("tblProductCatalogue");
            foreach (DataRow item in rawData.Tables["tblProductCatalogue"].Rows)
            {
                products.Add(new Product(int.Parse(item["ID"].ToString()), item["ProductSuite"].ToString()));
            }
            return products;
        }
    }
}
