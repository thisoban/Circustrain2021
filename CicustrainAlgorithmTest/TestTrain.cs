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
        public void TestOrderAnimalsInWagon1()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>()
            {
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(1, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Carnivore),
                 new Animal(3, Diet.Carnivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(1, Diet.Carnivore)
            };

          
            train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(5, train.Wagons.Count());
        }

        [TestMethod]
        public void TestFitTenAnimalsInOneWagonWith1SizeHerbivore()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore)
            };
         
            train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(1, train.Wagons.Count());
        }
        [TestMethod]
        public void Make_4_wagons()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore)
            };
        
            train.OrderAnimalsInWagons(animals);

            Assert.AreEqual(4, train.Wagons.Count());
        }

    }
}
