using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoolandia.Habitat
{
    public class ForestHabitat : Habitat, IForestHabitat
    {
        public string trimTrees()
        {
            return "The trees have been trimmed";
        }
        public int normalTemp { get; set;}

        public double squareFeet { get; set; }
    }
}
