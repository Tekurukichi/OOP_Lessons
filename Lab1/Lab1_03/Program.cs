using System;
using System.Text;

namespace Lab1_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Enter the employee's surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter the employee's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the employee's wrksp:");
            string wrksp = Console.ReadLine();

            Console.WriteLine("Enter the employee's years of experience:");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name,  surname);
            {
                employee.Pos = wrksp;
                employee.Experience = experience;
            };

            double salary = employee.calculateSalary();
            double tax = employee.calculateTax();

            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Last Name: {employee.Name}");
            Console.WriteLine($"First Name: {employee.Surname}");
            Console.WriteLine($"wrksp: {employee.Pos}");
            Console.WriteLine($"Salary: {salary:C2}");
            Console.WriteLine($"Tax: {tax:C2}");

            Console.ReadKey();
        }
        }
    }
