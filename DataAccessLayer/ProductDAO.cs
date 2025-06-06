using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;

        public ProductDAO()
        {
            Product chai = new Product()
            {
                ProductId = 1,
                ProductName = "Chai",
                CategoryId = 3,
                UnitsInStock = 12,
                UnitPrice = 18
            };
            Product chang = new Product()
            {
                ProductId = 2,
                ProductName = "Chang",
                CategoryId = 1,
                UnitsInStock = 23,
                UnitPrice = 19
            };
            Product aniseed = new Product()
            {
                ProductId = 3,
                ProductName = "Aniseed Syrup",
                CategoryId = 2,
                UnitsInStock = 23,
                UnitPrice = 10
            };
            listProducts = new List<Product> { chai, chang, aniseed };
        }
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                //using var db = new MyStoreContext();
                //listProducts = db.Products.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return listProducts;
        }
        public static void SaveProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                p.ProductId = product.ProductId;
                p.ProductName = product.ProductName;
                p.UnitPrice = product.UnitPrice;
                p.UnitsInStock = product.UnitsInStock;
                p.CategoryId = product.CategoryId;
            }
        }

        public static void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(product);
                }
            }
        }

        public static Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }

        public static void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitsInStock = product.UnitsInStock;
                    p.CategoryId = product.CategoryId;
                }
            }
        }
    }
}
