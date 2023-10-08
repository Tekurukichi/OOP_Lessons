using System;
using Lab3_01.Interface;

namespace Lab3_01
{
    public class MicroOrganism : LivingOrganism, IReproducible
    {
        public int MutationRate { get; private set; }
        
        public MicroOrganism(int energy, int age, int size, int mutationRate) : base (energy, age, size)
        {
            MutationRate = mutationRate;
        }
        
        public override void Live()
        {
            if (new Random().Next(100) < MutationRate)
            {
                Size += 1;
            }
            
        }
        
        public LivingOrganism Reproduce()
            {
                return new MicroOrganism(Energy/2,0,Size,MutationRate);
            }
    }
}