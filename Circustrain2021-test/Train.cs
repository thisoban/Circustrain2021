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

        public void SortedAnimals(List<Animal> inputanimals)
        {
            List<Animal> Carnivore = inputanimals.Where(x => x.Diet == Diet.Carnivore).ToList();
            List<Animal> Herbivore = inputanimals.Where(x => x.Diet == Diet.Herbivore).ToList();
            
            List<Animal> sortedAnimals = new List<Animal>();
          
            sortedAnimals.AddRange(Carnivore.Where(x=> x.Weight == Weight.Small)); 
            sortedAnimals.AddRange(Herbivore.Where(x=> x.Weight == Weight.Medium)); 
            sortedAnimals.AddRange(Carnivore.Where(x => x.Weight == Weight.Medium)); 
            sortedAnimals.AddRange(Herbivore.Where(x=> x.Weight == Weight.Large)); 
            sortedAnimals.AddRange(Herbivore.Where(x=> x.Weight == Weight.Small)); 
            sortedAnimals.AddRange(Carnivore.Where(x=> x.Weight == Weight.Large)); 
 
            OrderAnimalsInWagons(sortedAnimals);
        }
        public void OrderAnimalsInWagons(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                SearchForAvaibleWagon(animal).PlaceAnimal(animal);
            }
        }
       
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
        private void AddWagon(Wagon wagon)
        {
            _wagons.Add(wagon);
        }
    }
}
