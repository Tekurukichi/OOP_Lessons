using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address MyAddress = new Address();
            MyAddress.index = "0524695";
            MyAddress.country = "Ukraine";
            MyAddress.city = "Kyiv";
            MyAddress.street = "Obl Prosp";
            MyAddress.house = "12a";
            MyAddress.apartment = "34";
            Console.WriteLine($"Адреса: {MyAddress.country}, {MyAddress.street}, {MyAddress.city}," +
                              $"{MyAddress.house}, {MyAddress.apartment}, {MyAddress.index}");


            

        }
    }
}