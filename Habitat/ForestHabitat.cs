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
