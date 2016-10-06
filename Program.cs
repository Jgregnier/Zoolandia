using System;
using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal redSquirrel = new RedSquirrel
            {
                name = "Squirrel Bro",
                numberOfLegs = 4,
                weight = 2.5M
            };

            Animal yellowSquirrel = new YellowSquirrel
            {
                name = "Squirrel Dude",
                numberOfLegs = 4,
                weight = 1.5M
            };

            Animal gator = new Gator
            {
                name = "Chompy",
                numberOfLegs = 4,
                weight = 200M
            };

            Animal chineseGator = new ChineseGator
            {
                name = "Chompy's chinese cousin",
                numberOfLegs = 4,
                weight = 175M
            };

            Animal dog = new Dog
            {
                name = "Ralph",
                numberOfLegs = 3,
                weight = 50M
            };

            Animal wolf = new Wolf
            {
                name = "Wolf Bro",
                numberOfLegs = 4,
                weight = 100M
            };

            List<Animal> pets = new List<Animal>();

            pets.Add(redSquirrel);
            pets.Add(yellowSquirrel);
            pets.Add(gator);
            pets.Add(chineseGator);
            pets.Add(dog);
            pets.Add(wolf);

            foreach (Animal animal in pets)
            {
                Console.WriteLine($"I have a {animal.getSpecies()} named {animal.name} he has {animal.numberOfLegs} legs and weighs {animal.weight} pounds, he goes {animal.Noise()}!");
                Console.WriteLine($"{animal.Feed("porkchop", 5)}");
                Console.WriteLine($"{animal.sleep()} \r\n");
            };
        }
    }
}
