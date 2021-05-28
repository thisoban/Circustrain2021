using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
   public class Herbivore : Animal
    {
       
        public Herbivore(Weight weight)
        {
            Weight = weight;
            Diet = Diet.Herbivore;
        }

        public override bool WontBeEaten(List<Animal> animals)
        {
            Animal biggestCarnivoreAnimal = animals.Where(a => a.Diet == Diet.Carnivore).FirstOrDefault();

            return biggestCarnivoreAnimal == null || biggestCarnivoreAnimal.Weight < Weight;
        }
    }
}
