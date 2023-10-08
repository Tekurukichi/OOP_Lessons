using System.Collections.Generic;
using System.Linq;
using Lab3_01.Interface;

namespace Lab3_01
{
    public class EcoSystem
    {

        internal List<LivingOrganism> Organism { get; private set; } = new List<LivingOrganism>();

        public void AddOrganism(LivingOrganism organism)
        {
            Organism.Add(organism);
        }

        public void SimulateDay()
        {
            List<LivingOrganism> babies = new List <LivingOrganism>();
            foreach (var organism in Organism)
            {
                organism.Live();

                if (organism is IReproducible reproducible)
                {
                    var baby = reproducible.Reproduce();
                    if (baby != null) babies.Add(baby);
                }

                if (organism is IPredator predator)
                {
                    var prey = Organism.FirstOrDefault(o => o != organism);
                    if (prey != null) predator.Hunt(prey);
                }
            }

            Organism.RemoveAll(o => o.Energy <= 0);
                Organism.AddRange(babies);
            }
        }
    }
