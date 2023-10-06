using System;
using System.IO;

namespace Lab1_03
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pos { get; set; }
        public int Experience { get; set; }
        
        public  Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public double calculateSalary()
        {
            double salary = 3000;
            double expBonus = 1000 * Experience;

            return salary + expBonus;
        }

        public double calculateTax()
        {
            double salary = calculateSalary();
            double taxRate = 0.20;
            
            return salary * taxRate;
        }
    }
}