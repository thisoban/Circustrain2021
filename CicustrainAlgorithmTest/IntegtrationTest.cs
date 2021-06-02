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
                new Carnivore  (Weight.Small),
                new Carnivore  (Weight.Medium),
                new Carnivore  (Weight.Large),
                new Herbivore  (Weight.Small),
                new Herbivore  (Weight.Medium),
                new Herbivore  (Weight.Large)

            },
            new Animal[]
            {
                new Carnivore  (Weight.Small),
                new Carnivore  (Weight.Medium),
                new Carnivore  (Weight.Large),
                new Herbivore  (Weight.Small),
                new Herbivore  (Weight.Medium),
                new Herbivore  (Weight.Large)
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
        public void TestMatrix_placing_different_animals_together_in_one_wagon()
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
        public void Distribute_Animals_Into_2_Wagons_H5_1_H3_3_H1_4()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small)
            };
            Train train =  new Train();
            train.SortedAnimals(herbivoreherd);
            Assert.AreEqual(2, train.Wagons.Count());
        }
        [TestMethod]
        public void Distribute_Animals_Into_6_Wagons_C5_2_C3_3_H5_3_H1_1()
        {
            List<Animal> MixedHerd = new List<Animal>()
            {
                new Carnivore(Weight.Large),
                new Carnivore(Weight.Large),
                new Carnivore(Weight.Medium),
                new Herbivore(Weight.Large),
                new Carnivore(Weight.Medium),
                new Herbivore(Weight.Large),
                new Carnivore(Weight.Medium),
                new Herbivore(Weight.Large),
                new Carnivore(Weight.Small)
            };
            Train train = new Train();
            train.SortedAnimals(MixedHerd);


            foreach (Wagon wagon in train.Wagons)
            Assert.IsTrue(wagon.WagonAnimals.Where(x => x.Diet == Diet.Carnivore).ToList().Count <= 1);
            Assert.AreEqual(6, train.Wagons.Count());
        }

        [TestMethod]
        public void Distribute_Animals_into_8_Wagons_H1_5_H3_5_H5_5_C1_2_C3_2_C5_2()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Small),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Large),
                new Carnivore(Weight.Small),
                new Carnivore(Weight.Small),
                new Carnivore(Weight.Medium),
                new Carnivore(Weight.Medium),
                new Carnivore(Weight.Large),
                new Carnivore(Weight.Large)
            };
            Train train = new Train();
            train.SortedAnimals(animals);
            foreach (Wagon wagon in train.Wagons)
            Assert.IsTrue(wagon.WagonAnimals.Where(x => x.Diet == Diet.Carnivore).ToList().Count <= 1);
            Assert.AreEqual(8, train.Wagons.Count());
        }

        [TestMethod]
        public void Distribute_Animals_Into_2_Wagons_H5_2_H3_3_C1_1()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Carnivore(Weight.Small),
                new Herbivore(Weight.Large),
                new Herbivore(Weight.Large)
            };
            Train train = new Train();
            train.SortedAnimals(herbivoreherd);
            foreach (Wagon wagon in train.Wagons)
            Assert.IsTrue(wagon.WagonAnimals.Where(x => x.Diet == Diet.Carnivore).ToList().Count <= 1);
            Assert.AreEqual(2, train.Wagons.Count());
        }
        [TestMethod]
        public void Distribute_Animals_Into_2_Wagons_C1_1_H5_2_H3_3_()
        {
            List<Animal> herbivoreherd = new List<Animal>()
            {
                new Carnivore(Weight.Small) ,
                new Herbivore(Weight.Large) ,
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Medium),
                new Herbivore(Weight.Large)
            };
            Train train = new Train();
            train.SortedAnimals(herbivoreherd);
            foreach (Wagon wagon in train.Wagons)
            Assert.IsTrue(wagon.WagonAnimals.Where(x => x.Diet == Diet.Carnivore).ToList().Count <= 1);
            Assert.AreEqual(2, train.Wagons.Count());
        }
    }
}
