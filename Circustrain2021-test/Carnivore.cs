using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
    public class Carnivore : IAnimal
    {
        public Weight Weight { get; }
        public Diet Diet { get; }

        public Carnivore( Weight weight)
        {
            Weight = weight;
        }

        public bool WontBeEaten(List<Animal> animals)
        {
            throw new NotImplementedException();
        }
    }
}
