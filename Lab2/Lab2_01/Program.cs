using System;
using System.Globalization;
using System.Text;

namespace Lab2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("First side rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second side rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Area rectangle: {rectangle.Area}");
            Console.WriteLine($"Perimeter rectangle:  {rectangle.Perimeter}");

            
        }
    }
}