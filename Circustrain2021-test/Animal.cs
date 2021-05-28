using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrain2021_test
{
    public abstract class Animal 
    {
        public  Weight Weight { get; set; }
        public  Diet Diet { get; set; }

        public override string ToString()
        {
            return Weight.ToString() + " " + Diet.ToString();
        }

        public abstract bool WontBeEaten(List<Animal> animals);

    }
}
