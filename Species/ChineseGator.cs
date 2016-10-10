using Zoolandia.Interfaces;

namespace Zoolandia.Species
{
    public class ChineseGator : Species
    {
        public override string GetSpecies()
        {
            return "Alligator Sinensis";
        }
        public override string Noise()
        {
            return "Wraw wraw wraw wraw";
        }
    }
}