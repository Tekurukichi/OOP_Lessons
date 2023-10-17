using System;
using System.Collections.Generic;
using System.Linq;
using Lab4_01.Interface;

namespace Lab4_01
{
    public class Store : ISearchable
    {
        internal List<Product> products;
        private List<User> users;
        private List<Order> orders;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void PlaceOrder(User user, List<Product> orderedProducts, List<int> quantities)
        {
            if (user != null && orderedProducts.Count == quantities.Count)
            {
                Order order = new Order
                {
                    Products = orderedProducts,
                    Quantities = quantities,
                    OrderStatus = "Pending"
                };
                user.PurchaseHistory.Add(order);
                orders.Add(order);
            }
            else
            {
                Console.WriteLine("Invalid order request.");
            }
        }

        public List<Product> SearchByPrice(decimal minPrice, decimal maxPrice)
        {
            return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SearchByRating(int minRating)
        {
            return products.Where(p => p.Rating >= minRating).ToList();
        }
    }
}