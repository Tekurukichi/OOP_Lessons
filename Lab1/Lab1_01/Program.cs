using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                Index = "0524695",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Obl Prosp",
                House = "12a",
                Apartment = "34",
            };
            Console.WriteLine($"Адреса: {address.Country}, {address.Street}, {address.City}," +
                              $"{address.House}, {address.Apartment}, {address.Index}");


            

        }
    }
}