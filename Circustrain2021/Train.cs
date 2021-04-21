using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrain2021
{
    public class Train
    {
        private readonly List<Wagon> _wagons;

        public IEnumerable<Wagon> wagons { get { return _wagons; } }

        public Train() { _wagons = new List<Wagon>(); }

        public void OrderAnimalsInWagons(List<Animal> inputAnimals)
        {
            foreach (Animal animal in inputAnimals.OrderBy(a => a.Diet).ThenBy(a => a.Weight).ToList())
            {
                SearchForAvaibleWagon(animal).PlaceAnimal(animal);
            }
        }

        private Wagon SearchForAvaibleWagon(Animal animal)
        {
            foreach (Wagon wagon in _wagons)
            {
                if (wagon.CanAnimalBePlaced(animal))
                {
                    return wagon;
                }
            }

            Wagon newWagon = new Wagon();
            AddWagon(newWagon);
            return newWagon;
        }
        public void AddWagon(Wagon wagon)
        {
            _wagons.Add(wagon);
        }
    }
}
