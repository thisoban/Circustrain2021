using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circustrain2021
{
    public class Wagon
    {
        private readonly List<Animal> _animalsInWagon;
        private const int _maxCapacity = 10;
        private Animal _biggestCarnivore;
        private Animal _BiggestHerbivore;

        public IEnumerable<Animal> Animals => _animalsInWagon;

        public Wagon()
        {
            _animalsInWagon = new List<Animal>();
        }
        
        public bool CanAnimalBePlaced(Animal animal)
        {
            return IsSpaceAvaiable(animal) && WontBeEaten(animal);
        }
        
        private bool IsSpaceAvaiable(Animal animal)
        {
            return _animalsInWagon.Sum(a => a.Weight) + animal.Weight <= _maxCapacity;
        }

        private bool WontBeEaten(Animal animal)
        {
            if (animal.Diet == Diet.Carnivore)
                return _biggestCarnivore == null
                    && (_BiggestHerbivore == null || _BiggestHerbivore.Weight > animal.Weight);
            if(animal.Diet == Diet.Herbivore)
                return _biggestCarnivore == null
                     || _biggestCarnivore.Weight < animal.Weight;
            return false;
        }
        public void PlaceAnimal(Animal animal)
        {
            if(CanAnimalBePlaced(animal))
            {
                if (animal.Diet == Diet.Carnivore &&
                    (_biggestCarnivore == null || animal.Weight >= _biggestCarnivore.Weight))
                    _biggestCarnivore = animal;
                else if (animal.Diet == Diet.Herbivore &&
                    (_BiggestHerbivore == null || animal.Weight >= _BiggestHerbivore.Weight))
                    _BiggestHerbivore = animal;
                _animalsInWagon.Add(animal);
            }
        }
    }
}
