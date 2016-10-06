namespace Zoolandia
{
    public class Dog : Animal
    {
        public override string getSpecies()
        {
            return "Canis Lupus Familiaris";
        }
        public string Feed(string food, int number)
        {
            return $"{this.name} ate {number} {food}s";
        }
        public override string Noise()
        {
            return "Woof Woof";
        }
    }
}
