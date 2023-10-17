using System.Collections.Generic;
using System.Linq;

namespace Lab4_01
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }
        public decimal TotalCost => Products.Zip(Quantities, (p, q) => p.Price * q).Sum();
        public string OrderStatus { get; set; }
    }
}