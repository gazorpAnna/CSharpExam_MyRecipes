using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace CSharpExam_MyRecipes
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            DeliciousDBEntities1 db = new DeliciousDBEntities1();

            System.Data.Entity.DbSet<Products> products = db.Products;
            var productsInRecipe = db.ProductsInRecipe;
            var recipes = db.Recipe;


            foreach (var product in products.Where(x => x.Name.StartsWith("B")))
            {
                Console.WriteLine(product.Name);
            }

            foreach (var recipe in recipes)
            {
                Console.WriteLine($"Per la recepta {recipe.Name} necessites:");
                foreach (var product in productsInRecipe.Where(x => x.IdRecipe == recipe.Id))
                {
                    var productO = products.Find(product.Id);
                    Console.WriteLine($"{product.Qty} unitats de {productO.Name}");
                }
            }

            Console.ReadLine();
        }*/

        
    }
}
