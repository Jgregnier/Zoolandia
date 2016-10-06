using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoolandia
{
    public class Squirrel : Animal
    {
        public override string getSpecies()
        {
            return "Sciuridae";
        }
        public override string Noise()
        {
           return "Squeek squeek";
        }
    }
}
