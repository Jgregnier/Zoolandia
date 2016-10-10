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
            //Making Dog Friend
            Animal myOnlyFriend = new Animal();
            myOnlyFriend.species = new Dog();
            myOnlyFriend.genus = new Canis();

            myOnlyFriend.name = "Winston Beauregard";
            myOnlyFriend.numberOfLegs = 3;
            myOnlyFriend.weight = 70M;

            //Making Squirrel
            Animal annoyingSquirrel = new Animal();
            annoyingSquirrel.species = new RedSquirrel();
            annoyingSquirrel.genus = new Sciuridae();

            annoyingSquirrel.name = "Annoying Squirrel";
            annoyingSquirrel.numberOfLegs = 4;
            annoyingSquirrel.weight = 1M;

            //Making the habitat
            ForestHabitat ForestHabitat = new ForestHabitat();

            //Adding my animals to the habitat
            ForestHabitat.Inhabitants.Add(myOnlyFriend);
            ForestHabitat.Inhabitants.Add(annoyingSquirrel);

            //Habitat properties
            ForestHabitat.normalTemp = 75;
            ForestHabitat.squareFeet = 100;
            ForestHabitat.public_name = "The Happy Forest Habitat";

            //Showing the animals are in the habitat, and that properties/ methods are implemented correctly
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
