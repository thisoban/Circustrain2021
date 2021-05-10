using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
    public class Train
    {
        private readonly List<Wagon> _wagons;

        public IEnumerable<Wagon> Wagons { get { return _wagons; } }

        public Train() => _wagons = new List<Wagon>();

        public void SortAnimals(List<Animal> InputAnimals)
        {
            Animal[][] animals = new Animal[2][];
            List<Animal> Carnivores = InputAnimals.Where(x => x.Diet == Diet.Carnivore).OrderByDescending(x => x.Weight).ToList();
            List<Animal> Herbvivores = InputAnimals.Where(x => x.Diet == Diet.Herbivore).OrderBy(x => x.Weight).ToList();
            animals[0] = Carnivores.ToArray();
            animals[1] = Herbvivores.ToArray();
         
        }
        public void OrderAnimalsInWagons(Animal[][] animals)
        {

            foreach (Animal animal in animals[0])
            {
                SearchForAvaibleWagon(animal).PlaceAnimal(animal);
            }
            while (animals[1].Length > 0)
            {
                animals[1].First();
               

            }
        }
        private void AddWagon(Wagon wagon) => _wagons.Add(wagon);
        private Wagon SearchForAvaibleWagon(Animal animal)
        {
            foreach (Wagon wagon in _wagons)
            {
                if (wagon.CanAnimalBePlaced(animal)) return wagon;
            }

            Wagon newWagon = new Wagon();
            AddWagon(newWagon);
            return newWagon;
        }
    }
}
