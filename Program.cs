using System;
using Zoolandia.Animals;
using Zoolandia.Species;
using Zoolandia.Genus;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal myOnlyFriend = new Animal();

            //Establishing my dog's Species
            Species.Species dog = new Dog();

            //Establishing my dog's Genus
            Genus.Genus canis = new Canis();

            myOnlyFriend.species = dog;
            myOnlyFriend.genus = canis;

            //Making default animal properties
            myOnlyFriend.name = "Winston Beauregard";
            myOnlyFriend.numberOfLegs = 4;
            myOnlyFriend.weight = 70M;

            //Making Squirrel
            Animal annoyingSquirrel = new Animal();
            Species.Species squirrel = new RedSquirrel();
            Genus.Genus squirrelGenus = new Sciuridae();

            annoyingSquirrel.species = squirrel;
            annoyingSquirrel.genus = squirrelGenus;

            annoyingSquirrel.name = "Annoying Squirrel";
            annoyingSquirrel.weight = 1M;

            //Making Alligator
            Animal dirtyAlligatorBastard = new Animal();
            Species.Species gator = new Gator();
            Genus.Genus gatorGenus = new Alligatoridae();

            dirtyAlligatorBastard.species = gator;
            dirtyAlligatorBastard.genus = gatorGenus;

            dirtyAlligatorBastard.name = "The Stupid Alligator";

            Console.WriteLine($"I had a RAD dog named {myOnlyFriend.name}\r\nHe was a {myOnlyFriend.species.GetSpecies()} of the {myOnlyFriend.genus.GetGenus()} Family");
            Console.WriteLine($"{myOnlyFriend.name} used to always say {myOnlyFriend.species.Noise()}");
            Console.WriteLine($"One day a {annoyingSquirrel.species.GetSpecies()} of the {annoyingSquirrel.genus.GetGenus()} family ran onto our property, lets call him {annoyingSquirrel.name}");
            Console.WriteLine($"{myOnlyFriend.name} weighed {myOnlyFriend.weight} Pounds, {annoyingSquirrel.name} only weighed {annoyingSquirrel.weight} Pound");
            Console.WriteLine($"After {myOnlyFriend.name} chased the intruder off our property {annoyingSquirrel.name} called his friend {dirtyAlligatorBastard.name} To fight {myOnlyFriend.name}");
            Console.WriteLine($"{myOnlyFriend.Sleep()}");
            Console.WriteLine($"{dirtyAlligatorBastard.Feed("Winston")} :(");
        }
    }
}
