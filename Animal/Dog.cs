using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoolandia
{
    public class Dog : Animal
    {
        public override string getSpecies()
        {
            return "Canis Lupus Familiaris";
        }
        public override string Noise()
        {
            return "Woof Woof";
        }
    }
}
