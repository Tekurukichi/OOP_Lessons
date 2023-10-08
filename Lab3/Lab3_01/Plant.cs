using System;
using Lab3_01.Interface;

namespace Lab3_01
{
    public class Plant : LivingOrganism, IReproducible
    {
        public int PhotosynthethisEfficiency { get; private set; }
        
        public Plant(int energy, int age, int size, int photosynthethisEfficiency) : base (energy, age, size)
        {
            PhotosynthethisEfficiency = photosynthethisEfficiency;
        }
        public override void Live()
        {
            Energy += PhotosynthethisEfficiency;
        }
        public LivingOrganism Reproduce()
        {
            Energy -= 5;
            return new Plant(Energy / 2, 0, Size / 2, PhotosynthethisEfficiency);
        }
    } 
}