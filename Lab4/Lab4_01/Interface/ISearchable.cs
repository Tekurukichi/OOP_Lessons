using System.Collections.Generic;

namespace Lab4_01.Interface
{
    public interface ISearchable
    {
        List<Product> SearchByPrice(decimal minPrice, decimal maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int minRating);
    }
}