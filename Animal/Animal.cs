using Zoolandia.Genus;
using Zoolandia.Species;

namespace Zoolandia.Animals
{
    public class Animal
    {
        //Species
        public Species.Species species { get; set; }
        //Genus
        public Genus.Genus genus { get; set; }

        //All animals have name, number of legs, and weight
        public string name { get; set; }
        public int numberOfLegs { get; set; }
        public decimal weight { get; set; }

        // Overloaded method of Feed
        public string Feed(string food)
        {
            return $"{this.name} ate the {food}";
        }
        public string Feed(string food, int number)
        {
            return $"{this.name} ate {number} {food}s";
        }

        //All Animals have to sleep
        public string Sleep()
        {
            return $"{this.name} is now sleeping";
        }

        // Method Moved To Genus 

        //Specific to genus
        //public virtual string GetHideType()
        //{
        //return "Unknown Hide type";
        //}

        // Method Moved To Species 

        //Will be different for each species
        //public virtual string GetSpecies()
        //{
        //return "Unknown Species";
        //}

        // Method Moved To Species 

        //Will be different for each species
        //public virtual string Noise()
        //{
        //return "Meow?";
        //}
    }
}
