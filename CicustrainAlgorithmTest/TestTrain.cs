using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrain2021_test;
using System.Collections.Generic;
using System.Linq;

namespace CicustrainAlgorithmTest
{
    [TestClass]
    public class TestTrain
    {
        [TestMethod]
        public void TestOrderAnimalsInWagon()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>()
            {
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Herbivore),
                 new Animal(Weight.Large, Diet.Herbivore),
                 new Animal(Weight.Large, Diet.Herbivore),
                 new Animal(Weight.Large, Diet.Herbivore),
                 new Animal(Weight.Large, Diet.Carnivore),
                 new Animal(Weight.Medium, Diet.Carnivore),
                 new Animal(Weight.Medium, Diet.Herbivore),
                 new Animal(Weight.Medium, Diet.Herbivore),
                 new Animal(Weight.Medium, Diet.Herbivore),
                 new Animal(Weight.Small, Diet.Carnivore)
            };

          
         //   train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(5, train.Wagons.Count());
        }

        [TestMethod]
        public void TestFitTenAnimalsInOneWagonWithWeight_smallHerbivore()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore)
            };
         
          //  train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(1, train.Wagons.Count());
        }
        [TestMethod]
        public void Make_4_wagons()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore),
                new Animal(Weight.Small, Diet.Herbivore)
            };
        
           //train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(4, train.Wagons.Count());
        }

    }
}
