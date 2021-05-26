using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
    public class Carnivore : Animal
    {
        public Weight Weight { get; }
        public Diet Diet { get; }

        public Carnivore(Weight weight)
        {
            Weight = weight;
            Diet = Diet.Carnivore;
        }

        public override bool WontBeEaten(List<Animal> animals)
        {
            Animal biggestCarnivoreAnimal = animals.Where(a => a.Diet == Diet.Carnivore).FirstOrDefault();
            Animal smallestHerbivoreAnimal = animals.OrderBy(a => a.Weight).Where(a => a.Diet == Diet.Herbivore).FirstOrDefault();

            return biggestCarnivoreAnimal == null && (smallestHerbivoreAnimal == null || smallestHerbivoreAnimal.Weight > Weight);
        }
    }
}
