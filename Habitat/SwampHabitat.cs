using Zoolandia.Interfaces;

namespace Zoolandia.Habitat
{
    public class SwampHabitat : Habitat, ISwampHabitat
    {
        public string creepyBubbles ()
        {
            return "Creepy bubbles rise to the surface of the swamp";
        }
        public int waterTemp {get;set;}
        public int waterViscosity { get; set; }
    }
}
