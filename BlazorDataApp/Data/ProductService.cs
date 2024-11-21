using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDataApp.Data
{
    public class ProductService
    {
        public Task<List<Product>> GetProductsAsync()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Buffalo Chicken", Description = "Spicy chicken, hot sauce and bleu cheese.", Price = 12.75m, ImageUrl = "images/buffalo-chicken.jpg" },
                new Product { Id = 2, Name = "The Baconatorizer", Description = "It has EVERY kind of bacon.", Price = 11.99m, ImageUrl = "images/baconator.jpg" },
                new Product { Id = 3, Name = "Veggie Delight", Description = "It's like salad, but on a pizza.", Price = 11.50m, ImageUrl = "images/veggie-delight.jpg" }
            };

            return Task.FromResult(products);
        }
    }
}
