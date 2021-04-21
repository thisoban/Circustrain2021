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

        public int Animals => _animalsInWagon.Count();

        public Wagon() => _animalsInWagon = new List<Animal>();
        
        public bool CanAnimalBePlaced(Animal animal) => IsSpaceAvaiable(animal) && animal.WontBeEaten(_animalsInWagon);
        public void PlaceAnimal(Animal animal)
        {
            if (CanAnimalBePlaced(animal)) _animalsInWagon.Add(animal);
        }

        private bool IsSpaceAvaiable(Animal animal) => _animalsInWagon.Sum(a => a.Weight) + animal.Weight <= _maxCapacity;
    }
}
