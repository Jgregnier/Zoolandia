using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitat
{
    public class Habitat
    {
        public List<Animal> Inhabitants = new List<Animal>();
        public string public_name { get; set; }
    }

    public interface IForestHabitat
    {
        string trimTrees();
        int normalTemp { get; set; }
        double squareFeet { get; set; }
    }

    public interface ISwampHabitat
    {
        string creepyBubbles();
        int waterTemp { get; set; }
        int waterViscosity { get; set; }
    }
}
