using System;
using System.Collections.Generic;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal squirrel = new Squirrel
            {
                name = "Squirrel Bro",
                numberOfLegs = 4,
                weight = 2.5M
            };

            Animal gator = new Gator
            {
                name = "Chompy",
                numberOfLegs = 4,
                weight = 200M
            };

            Animal dog = new Dog
            {
                name = "Ralph",
                numberOfLegs = 3,
                weight = 50M
            };

            List<Animal> pets = new List<Animal>();

            pets.Add(squirrel);
            pets.Add(gator);
            pets.Add(dog);

            foreach (Animal animal in pets)
            {
                Console.WriteLine($"I have a {animal.getSpecies()} named {animal.name} he has {animal.numberOfLegs} legs and weighs {animal.weight} pounds, he goes {animal.Noise()}!");
                Console.WriteLine($"{animal.sleep()}");
            };
        }
    }
}
