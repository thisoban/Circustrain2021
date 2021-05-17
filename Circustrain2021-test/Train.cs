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
            
           // List<Animal> Carnivores = InputAnimals.Where(x => x.Diet == Diet.Carnivore).OrderByDescending(x => x.Weight).ToList();
            List<Animal> BiggestCarnivores = InputAnimals.Where(x => x.Diet == Diet.Carnivore).Where(x=>x.Weight == Weight.Large).ToList();
            List<Animal> MediumCarnivores = InputAnimals.Where(x => x.Diet == Diet.Carnivore).Where(x=>x.Weight == Weight.Medium).ToList();
            List<Animal> SmallCarnivores = InputAnimals.Where(x => x.Diet == Diet.Carnivore).Where(x=>x.Weight == Weight.Small).ToList();
            List<Animal> largeherbivore = InputAnimals.Where(x => x.Diet == Diet.Herbivore).Where(x =>x.Weight == Weight.Large).ToList();
            List<Animal> MediummHerbivore = InputAnimals.Where(x => x.Diet == Diet.Herbivore).Where(x => x.Weight == Weight.Medium).ToList();
            List<Animal> SmallHerbivore = InputAnimals.Where(x => x.Diet == Diet.Herbivore).Where(x => x.Weight == Weight.Small).ToList();
            OrderAnimalsInWagons(BiggestCarnivores);
            OrderAnimalsInWagons(SmallCarnivores);
            OrderAnimalsInWagons(MediummHerbivore);
            OrderAnimalsInWagons(MediumCarnivores);
            OrderAnimalsInWagons(largeherbivore);
            OrderAnimalsInWagons(SmallHerbivore);
           
            //OrderAnimalsInWagons(Herbvivores);

            foreach (Animal animal in MediumCarnivores)
            {
                if (animal.Weight == Weight.Medium)
                {

                }
            }

        }
        public void OrderAnimalsInWagons(List<Animal> Animal)
        {

            foreach (Animal animal in Animal)
            {
                SearchForAvaibleWagon(animal).PlaceAnimal(animal);
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
