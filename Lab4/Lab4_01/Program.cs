using System;
using System.Collections.Generic;

namespace Lab4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            
            store.AddProduct(new Product
            {
                Name = "Product 1",
                Price = 10.99m,
                Description = "Description 1",
                Category = "Category A",
                Rating = 4
            });

            store.AddProduct(new Product
            {
                Name = "Product 2",
                Price = 19.99m,
                Description = "Description 2",
                Category = "Category B",
                Rating = 5
            });

            
            User user1 = new User("user1", "password1");
            store.AddUser(user1);

            
            List<Product> orderedProducts = new List<Product> { store.products[0] };
            List<int> quantities = new List<int> { 2 };
            store.PlaceOrder(user1, orderedProducts, quantities);

            
            List<Product> cheapProducts = store.SearchByPrice(0, 15);
            List<Product> highRatedProducts = store.SearchByRating(4);

            
            Console.WriteLine("Cheap products:");
            foreach (var product in cheapProducts)
            {
                Console.WriteLine($"{product.Name}, Price: {product.Price}, Rating: {product.Rating}");
            }

            Console.WriteLine("\nHigh-rated products:");
            foreach (var product in highRatedProducts)
            {
                Console.WriteLine($"{product.Name}, Price: {product.Price}, Rating: {product.Rating}");
            }
        }
    }
}