using System;

namespace Circustrain2021
{
    public class Animal
    {
        public int Weight { get; }
        public Diet Diet { get; }

        public Animal(int wieght, Diet diet)
        {
            Weight = Weight;
            Diet = diet;
        }

        public override string ToString()
        {
            return Weight.ToString() + " " + Diet.ToString();
        }
    }
}
