using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
   public class Wagon
    {
        private readonly List<Animal> _animalsInWagon;
        private const int _maxCapacity = 10;

        

        public Wagon() => _animalsInWagon = new List<Animal>();

        public int Animals => _animalsInWagon.Count();

        public bool CanAnimalBePlaced(Animal animal) => IsSpaceAvaiable(animal) && animal.WontBeEaten(_animalsInWagon);

        private bool IsSpaceAvaiable(Animal animal) => _animalsInWagon.Sum(a => (int)a.Weight) + (int)animal.Weight <= _maxCapacity;
        public void PlaceAnimal(Animal animal)
        {
            if (CanAnimalBePlaced(animal)) _animalsInWagon.Add(animal);
        }
    }
}
