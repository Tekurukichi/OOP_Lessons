using System;

namespace Lab5_01
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            Speed = 60;
            Capacity = 30;
        }

        public override void Move()
        {
            Console.WriteLine("Driving a bus...");
        }
    }
}