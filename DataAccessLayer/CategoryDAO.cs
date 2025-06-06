using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            Category beverages = new Category()
            {
                CategoryId = 1,
                CategoryName = "Beverages"
            };
            Category condiments = new Category()
            {
                CategoryId = 2,
                CategoryName = "Condiments"
            };
            Category confections = new Category()
            {
                CategoryId = 3,
                CategoryName = "Confections"
            };
            Category dairy = new Category()
            {
                CategoryId = 4,
                CategoryName = "Dairy Products"
            };
            Category grains = new Category()
            {
                CategoryId = 5,
                CategoryName = "Grains/Cereals"
            };
            Category meat = new Category()
            {
                CategoryId = 6,
                CategoryName = "Meat/Poultry"
            };
            Category produce = new Category()
            {
                CategoryId = 7,
                CategoryName = "Produce"
            };
            Category seafood = new Category()
            {
                CategoryId = 8,
                CategoryName = "Seafood"
            };

            var listCategories = new List<Category>();
            try
            {
                listCategories.Add(beverages);
                listCategories.Add(condiments);
                listCategories.Add(confections);
                listCategories.Add(dairy);
                listCategories.Add(grains);
                listCategories.Add(meat);
                listCategories.Add(produce);
                listCategories.Add(seafood);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return listCategories;
        }
    }
}
