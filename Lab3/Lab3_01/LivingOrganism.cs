using System;

namespace Lab3_01
{
    public abstract class LivingOrganism {
        public int Energy { get; internal set; }
        public int Age { get; protected set; }
        public int Size { get; protected set; }

        public LivingOrganism(int energy, int age, int size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }

        public abstract void Live();
    }
}