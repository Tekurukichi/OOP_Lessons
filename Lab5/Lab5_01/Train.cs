using System;

namespace Lab5_01
{
    public class Train : Vehicle
    {
        public Train()
        {
            Speed = 120;
            Capacity = 200;
        }

        public override void Move()
        {
            Console.WriteLine("Riding a train...");
        }
    }
}