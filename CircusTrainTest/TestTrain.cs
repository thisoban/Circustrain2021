using Circustrain2021;
using NUnit.Framework;
using System.Collections.Generic;

namespace CircusTrainTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
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
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(3, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Herbivore),
                 new Animal(5, Diet.Carnivore),
                 new Animal(3, Diet.Carnivore),
                 new Animal(1, Diet.Carnivore)
            };

            Train train = new Train();
            train.OrderAnimalsInWagons(animals);
            Assert.AreEqual(5, train.wagons.Count() ;
        }
    }
}