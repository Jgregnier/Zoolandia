using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoolandia
{
    public class Gator : Animal
    {
        public override string getSpecies()
        {
            return "Alligator Mississippiensis";
        }
        public override string Noise()
        {
            return "WRARRR";
        }
    }
}
