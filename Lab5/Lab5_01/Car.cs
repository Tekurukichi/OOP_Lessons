using System;

namespace Lab5_01
{
    public class Car : Vehicle

    {
        public Car()
        {
            Speed = 100;
            Capacity = 4;
        }

        public override void Move()
        {
            Console.WriteLine("Driving a car...");
        }
    }
}