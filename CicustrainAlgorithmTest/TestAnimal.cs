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
            Animal animal = new Animal(1, Diet.Herbivore);
            List<Animal> animals = new List<Animal>()
            {
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore)
            };
          
           Assert.IsTrue( animal.WontBeEaten(animals));
        }
    }
}
