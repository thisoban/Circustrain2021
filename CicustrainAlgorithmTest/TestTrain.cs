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
        public void Order_Animals_In_Wagon()
        {
            Train train = new Train();

            List<Animal> animals = new List<Animal>()
            {
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Small),
                 new Herbivore(Weight.Large),
                 new Herbivore(Weight.Large),
                 new Herbivore(Weight.Large),
                 new Carnivore(Weight.Large),
                 new Carnivore(Weight.Medium),
                 new Herbivore(Weight.Medium),
                 new Herbivore(Weight.Medium),
                 new Herbivore(Weight.Medium),
                 new Carnivore(Weight.Small)
            };

          
            train.SortedAnimals(animals);

            Assert.AreEqual(5, train.Wagons.Count());
        }

        [TestMethod]
        public void Fit_Ten_Animals_In_One_Wagon_With_Weight_smallHerbivore()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Small ),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small)
            };
         
           train.SortedAnimals(animals);

            Assert.AreEqual(1, train.Wagons.Count());
        }
        [TestMethod]
        public void four_wagons_exist()
        {
            Train train = new Train();
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small)
            };
        
           train.SortedAnimals(animals);

            Assert.AreEqual(4, train.Wagons.Count());
        }

    }
}
