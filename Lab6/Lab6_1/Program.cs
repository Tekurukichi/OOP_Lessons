using System;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Calculator<int> intCalculator = new Calculator<int>(
                (a, b) => a + b,   
                (a, b) => a - b,   
                (a, b) => a * b,   
                (a, b) => a / b    
            );

            int result1 = intCalculator.PerformOperation(10, 5, intCalculator.Addition);
            Console.WriteLine("Integer Addition: " + result1);

            int result2 = intCalculator.PerformOperation(10, 5, intCalculator.Subtraction);
            Console.WriteLine("Integer Subtraction: " + result2);

            int result3 = intCalculator.PerformOperation(10, 5, intCalculator.Multiplication);
            Console.WriteLine("Integer Multiplication: " + result3);

            int result4 = intCalculator.PerformOperation(10, 5, intCalculator.Division);
            Console.WriteLine("Integer Division: " + result4);

            
            Calculator<double> doubleCalculator = new Calculator<double>(
                (a, b) => a + b,   
                (a, b) => a - b,    
                (a, b) => a * b,   
                (a, b) => a / b    
            );

            double result5 = doubleCalculator.PerformOperation(10.5, 5.2, doubleCalculator.Addition);
            Console.WriteLine("Double Addition: " + result5);

            double result6 = doubleCalculator.PerformOperation(10.5, 5.2, doubleCalculator.Subtraction);
            Console.WriteLine("Double Subtraction: " + result6);

            double result7 = doubleCalculator.PerformOperation(10.5, 5.2, doubleCalculator.Multiplication);
            Console.WriteLine("Double Multiplication: " + result7);

            double result8 = doubleCalculator.PerformOperation(10.5, 5.2, doubleCalculator.Division);
            Console.WriteLine("Double Division: " + result8);
        
        }
    }
}