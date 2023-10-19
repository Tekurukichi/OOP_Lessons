using System;

namespace Lab5_01
{
    public abstract class Vehicle : TransportNetwork
    {
        public static int Speed { get; protected set; }
        public static int Capacity { get; protected set; }

        public abstract void Move();
        


    }
}