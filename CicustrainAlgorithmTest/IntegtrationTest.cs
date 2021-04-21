using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Circustrain2021_test;
using System.Collections.Generic;
using System.Linq;

namespace CicustrainAlgorithmTest
{
    [TestClass]
    public class IntegtrationTest
    {
        Animal[][] animalsarray =
        {
            new Animal[] {
                new Animal  (1, Diet.Carnivore),
                new Animal  (3, Diet.Carnivore),
                new Animal  (5, Diet.Carnivore),
                new Animal  (1, Diet.Herbivore),
                new Animal  (3, Diet.Herbivore),
                new Animal  (5, Diet.Herbivore)

            },
            new Animal[]
            {
                new Animal  (1, Diet.Carnivore),
                new Animal  (3, Diet.Carnivore),
                new Animal  (5, Diet.Carnivore),
                new Animal  (1, Diet.Herbivore),
                new Animal  (3, Diet.Herbivore),
                new Animal  (5, Diet.Herbivore)
            }
        };


        bool[][] TrueBoolMatrix = // animals from one side to other side
        {
            new bool[]
            {//1 carnivoor
                //1c     3c     5c     1h    3h   5h
                false, false, false, false, true, true
            },
            new bool[]
            {//3 carnivoor
                //1c     3c     5c     1h    3h   5h
                false, false, false, false, false , true
            },
            new bool[]
            {//5 carnivoor
                //1c     3c     5c     1h    3h   5h
                false, false, false, false, false, false
            },
            new bool[]
            {//1 herbivoor
                //1c     3c     5c     1h    3h   5h
                false, false, false, true, true, true
            },
            new bool[]
            {//3 herbivoor
                //1c   3c     5c     1h    3h   5h
                true, false, false, true, true, true
            },
            new bool[]
            {// 1 herbivoor
                //1c   3c     5c    1h    3h   5h
                true, true, false, true, true, true
            }
        };

        [TestMethod]
        public void TestMatrix_placing_different_animals_together()
        {

            for (int x = 0; x < animalsarray[0].Length; x++)
            {
                Wagon wagon = new Wagon();
                wagon.PlaceAnimal(animalsarray[0][x]);
                for (int y = 0; y < animalsarray[1].Length; y++)
                {
                    Assert.AreEqual(TrueBoolMatrix[x][y], wagon.CanAnimalBePlaced(animalsarray[1][y]));
                }
            }
        }
        [TestMethod]
        public void TestHerd1()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Animal(5, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore),
                new Animal(1, Diet.Herbivore)

            };
          Train train =  new Train();
            train.OrderAnimalsInWagons(herbivoreherd);
            Assert.AreEqual(2, train.Wagons.Count());
        }
        [TestMethod]
        public void TestHerd2()
        {
            List<Animal> MixedHerd = new List<Animal>()
            {
                new Animal(5, Diet.Carnivore),
                new Animal(5, Diet.Carnivore),
                new Animal(3, Diet.Carnivore),
                new Animal(5, Diet.Herbivore),
                new Animal(3, Diet.Carnivore),
                new Animal(5, Diet.Herbivore),
                new Animal(3, Diet.Carnivore),
                new Animal(5, Diet.Herbivore),
                new Animal(1, Diet.Carnivore)

            };
            Train train = new Train();
            train.OrderAnimalsInWagons(MixedHerd);
            Assert.AreEqual(6, train.Wagons.Count());
        }

        [TestMethod]
        public void TestHerd4()
        {

        }

        [TestMethod]
        public void TestHerd5()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Animal(3, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(1, Diet.Carnivore),
                new Animal(5, Diet.Herbivore),
                new Animal(5, Diet.Herbivore)


            };
            Train train = new Train();
            train.OrderAnimalsInWagons(herbivoreherd);
            Assert.AreEqual(2, train.Wagons.Count());
        }
        [TestMethod]
        public void TestHerd6()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Animal(1, Diet.Carnivore),
                new Animal(5, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
                new Animal(3, Diet.Herbivore),
              
                new Animal(5, Diet.Herbivore)
     

            };
            Train train = new Train();
            train.OrderAnimalsInWagons(herbivoreherd);
            Assert.AreEqual(2, train.Wagons.Count());
        }
    }
}
