using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam_MyRecipes.ImplementDataAccess
{
    class DataConsumer
    {
        private System.Data.Entity.DbSet<Products> products;
        private System.Data.Entity.DbSet<ProductsInRecipe> productsInRecipes;
        private System.Data.Entity.DbSet<Recipe> recipes;

        public DataConsumer()
        {
            this.retrieveDataFromDB();
        }

        public void retrieveDataFromDB()
        {
            DeliciousDBEntities1 db = new DeliciousDBEntities1();

            this.products = db.Products;
            this.productsInRecipes = db.ProductsInRecipe;
            this.recipes = db.Recipe;
        }
    }
}
