using System;

namespace Lab5_01
{
    public class Human
    {
        public int Speed { get; private set; }
        public Human(int speed)
        {
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine("Walking...");
        }
    }
}