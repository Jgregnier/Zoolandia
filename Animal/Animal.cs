namespace Zoolandia.Animals
{
    public class Animal
    {

        //All animals have name, number of legs, and weight
        public string name { get; set; }
        public int numberOfLegs { get; set; }
        public decimal weight { get; set; }

        //Will be different for each genus
        public virtual string Noise()
        {
            return "Meow?";
        }

        //Will be different for each species
        public virtual string getSpecies()
        {
            return "Unknown Species";
        }

        // Overloaded Method of Feed
        public string Feed(string food)
        {
            return $"{this.name} ate the {food}";
        }
        public string Feed(string food, int number)
        {
            return $"{this.name} ate {number} {food}s";
        }

        //All Animals have to sleep
        public string sleep()
        {
            return $"{this.name} is now sleeping";
        }
    }
}
