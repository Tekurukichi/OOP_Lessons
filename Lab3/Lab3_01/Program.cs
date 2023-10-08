using System;

namespace Lab3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            EcoSystem forest = new EcoSystem();
            
            forest.AddOrganism(new Animal(100, 5, 10, 6));
            forest.AddOrganism((new Plant(50,2,3,4)));
            forest.AddOrganism(new MicroOrganism(20,1,1,5));
            
            Console.WriteLine($"{forest.Organism.Count} initial quantity of organisms");

            for (int i = 0; i < 10; i++)
            {
                forest.SimulateDay();
                Console.WriteLine($"{forest.Organism.Count} organisms alive after {i + 1} day");
            }
            Console.WriteLine("Simulation finish");
        }
    }
}