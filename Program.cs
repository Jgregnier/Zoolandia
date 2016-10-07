using System;
using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Genus;
using Zoolandia.Species;
using Zoolandia.Habitat;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal myOnlyFriend = new Animal();

            myOnlyFriend.species = new Dog();
            myOnlyFriend.genus = new Canis();

            //Making default animal properties
            myOnlyFriend.name = "Winston Beauregard";
            myOnlyFriend.numberOfLegs = 4;
            myOnlyFriend.weight = 70M;

            //Making Squirrel
            Animal annoyingSquirrel = new Animal();
            annoyingSquirrel.species = new RedSquirrel();
            annoyingSquirrel.genus = new Sciuridae();

            annoyingSquirrel.name = "Annoying Squirrel";
            annoyingSquirrel.weight = 1M;

            //Making Alligator
            Animal dirtyAlligatorBastard = new Animal();
            dirtyAlligatorBastard.species = new Gator();
            dirtyAlligatorBastard.genus = new Alligatoridae();

            dirtyAlligatorBastard.name = "The Stupid Alligator";

            List<Animal> pets = new List<Animal>();

            pets.Add(myOnlyFriend);
            pets.Add(annoyingSquirrel);
            pets.Add(dirtyAlligatorBastard);

            ForestHabitat ForestHabitat = new ForestHabitat();
            ForestHabitat.Inhabitants.Add(myOnlyFriend);
            ForestHabitat.Inhabitants.Add(annoyingSquirrel);

            ForestHabitat.normalTemp = 75;
            ForestHabitat.squareFeet = 100;
            ForestHabitat.public_name = "The Happy Forest Habitat";

            foreach (Animal animal in ForestHabitat.Inhabitants)
            {
                Console.WriteLine($"{animal.name} The {animal.species.GetSpecies()} lives in {ForestHabitat.public_name}\r\n");
            }

            Console.WriteLine($"{ForestHabitat.public_name} has a normal temperature of {ForestHabitat.normalTemp}");
            Console.WriteLine($"{ForestHabitat.public_name} has an area of {ForestHabitat.squareFeet} square feet");
            Console.WriteLine($"{ForestHabitat.trimTrees()}");
        }
    }
}
