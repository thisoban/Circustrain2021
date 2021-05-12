using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrain2021_test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CicustrainAlgorithmTest
{[TestClass]
   public class TestWagon
    {
        [TestMethod]
        public void TestPlacing_HerbivoreAnimal_In_Empty_Wagon()
        {
            Animal animal1 = new Animal(Weight.Large, Diet.Herbivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(animal1);
            Assert.AreEqual(1, wagon.Animals);
        }
        [TestMethod]
        public void TestPlacing_CarnivoreAnimal_In_Empty_Wagon()
        {
            Animal animal1 = new Animal(Weight.Large, Diet.Carnivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(animal1);
            Assert.AreEqual(1, wagon.Animals);
        }
        [TestMethod]
        public void Test_Third_Animal_Doesnt_Fit_In_Wagon()
        {
            Animal animal1 = new Animal(Weight.Large, Diet.Herbivore);
            Animal animal2 = new Animal(Weight.Large, Diet.Herbivore);
            Animal animal3 = new Animal(Weight.Large, Diet.Herbivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(animal1);
            wagon.PlaceAnimal(animal2);
            Assert.IsFalse(wagon.CanAnimalBePlaced(animal3));
        }

        [TestMethod]
        public void Test_Placing_BIgherbivoor_BigCarnivoor_Same_wagon_Not_Allowed()
        {
            Animal herbivoor = new Animal(Weight.Large, Diet.Herbivore);
            Animal carnivoor = new Animal(Weight.Large, Diet.Carnivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(herbivoor);
            Assert.IsFalse(wagon.CanAnimalBePlaced(carnivoor));

        }

        [TestMethod]
        public void unvalid_placing_two_differnt_diet_same_weight_one_wagon()
        {
            Animal herbivoor = new Animal(Weight.Large, Diet.Herbivore);
            Animal carnivoor = new Animal(Weight.Large, Diet.Carnivore);
            Wagon wagon = new Wagon();
            wagon.PlaceAnimal(herbivoor);
            Assert.IsFalse(wagon.CanAnimalBePlaced(carnivoor));
        }
    }
}
