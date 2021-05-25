using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
    public class Animal : IAnimal
    {
        public Weight Weight { get; }
        public Diet Diet { get; }

        

        public Animal(Weight weight, Diet diet)
        {
            Weight = weight;
            Diet = diet;
        }

        public override string ToString()
        {
            return Weight.ToString() + " " + Diet.ToString();
        }

        public bool WontBeEaten(List<Animal> animals)
        {
            Animal biggestCarnivoreAnimal = animals.Where(a=> a.Diet == Diet.Carnivore).FirstOrDefault();
            Animal smallestHerbivoreAnimal = animals.OrderBy(a => a.Weight).Where(a=> a.Diet == Diet.Herbivore).FirstOrDefault();

            if (Diet == Diet.Carnivore)
            {
                return biggestCarnivoreAnimal == null && (smallestHerbivoreAnimal == null || smallestHerbivoreAnimal.Weight > Weight);
            }
            if (Diet == Diet.Herbivore)
            {
                return biggestCarnivoreAnimal == null || biggestCarnivoreAnimal.Weight < Weight;
            }

            return false;
        }
    }
}
