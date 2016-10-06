using System;

namespace Zoolandia
{
    public class Animal
    {
        public string name { get; set; }
        public int numberOfLegs { get; set; }
        public decimal weight { get; set; }

        public virtual string getSpecies()
        {
            return "Unknown Species";
        }
        public virtual string Noise()
        {
            return "Meow?";
        }

        public void sleep()
        {
            Console.WriteLine($"{this.name} is now sleeping");
        }

    }
}
