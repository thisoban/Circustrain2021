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
            Herbivore animal = new Herbivore(Weight.Small);
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small)
            };
          
           Assert.IsTrue( animal.WontBeEaten(animals));
        }
        [TestMethod]
        public void Animal_Herbivoor3_Wont_Be_eaten_by_small_carnivore()
        {
            Carnivore animal = new Carnivore(Weight.Small);
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium)
            };

            Assert.IsTrue(animal.WontBeEaten(animals));
        }

        [TestMethod]
        public void medium_Herbivoor_Wont_be_eaten_small_carnivore()
        {
            Carnivore animal = new Carnivore(Weight.Small);
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium)
            };

            Assert.IsTrue(animal.WontBeEaten(animals));
        }

        [TestMethod]
        public void medium_Herbivoor_Will_be_eaten_medium_carnivore()
        {
            Carnivore animal = new Carnivore(Weight.Medium);
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium)
            };

            Assert.IsFalse(animal.WontBeEaten(animals));
        }
        [TestMethod]
        public void medium_Herbivoor_Will_be_eaten_large_carnivore()
        {
            Carnivore animal = new Carnivore(Weight.Large);
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Medium)
            };

            Assert.IsFalse(animal.WontBeEaten(animals));
        }
    }
}
