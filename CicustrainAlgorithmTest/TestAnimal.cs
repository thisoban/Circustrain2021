using Circustrain2021_test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CicustrainAlgorithmTest
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]
        public void Animal_Herbivoor1_Wont_Be_eaten()
        {
            Animal animal = new Animal(Weight.Small, Diet.Herbivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore)
            };
          
           Assert.IsTrue( animal.WontBeEaten(animals));
        }
        [TestMethod]
        public void Animal_Herbivoor3_Wont_Be_eaten_by_small_carnivore()
        {
            Animal animal = new Animal(Weight.Small, Diet.Carnivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore)
            };

            Assert.IsTrue(animal.WontBeEaten(animals));
        }

        [TestMethod]
        public void medium_Herbivoor_Wont_be_eaten_small_carnivore()
        {
            Animal animal = new Animal(Weight.Small, Diet.Carnivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore)
            };

            Assert.IsTrue(animal.WontBeEaten(animals));
        }

        [TestMethod]
        public void medium_Herbivoor_Will_be_eaten_medium_carnivore()
        {
            Animal animal = new Animal(Weight.Medium, Diet.Carnivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore),
                new Animal(Weight.Medium, Diet.Herbivore)
            };

            Assert.IsFalse(animal.WontBeEaten(animals));
        }
        [TestMethod]
        public void medium_Herbivoor_Will_be_eaten_large_carnivore()
        {
            Animal animal = new Animal(Weight.Large, Diet.Carnivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Medium, Diet.Herbivore)
            };

            Assert.IsFalse(animal.WontBeEaten(animals));
        }
    }
}
