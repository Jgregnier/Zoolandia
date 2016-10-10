using Zoolandia.Interfaces;

namespace Zoolandia.Habitat
{
    public class ForestHabitat : Habitat, IForestHabitat
    {
        public string trimTrees()
        {
            return $"The trees have been trimmed in {this.public_name}";
        }
        public int normalTemp { get; set;}

        public double squareFeet { get; set; }
    }
}
