using System;
using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Genus;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal myOnlyFriend = new Animal();

            //Establishing my dog's Species
            Dog dog = new Dog();

            //Establishing my dog's Genus
            Canis canis = new Canis();

            myOnlyFriend.species = dog;
            myOnlyFriend.genus = canis;

            //Making default animal properties
            myOnlyFriend.name = "Winston Beauregard";
            myOnlyFriend.numberOfLegs = 4;
            myOnlyFriend.weight = 70M;

            //Making Squirrel
            Animal annoyingSquirrel = new Animal();
            RedSquirrel squirrel = new RedSquirrel();
            Sciuridae squirrelGenus = new Sciuridae();

            annoyingSquirrel.species = squirrel;
            annoyingSquirrel.genus = squirrelGenus;

            annoyingSquirrel.name = "Annoying Squirrel";
            annoyingSquirrel.weight = 1M;

            //Making Alligator
            Animal dirtyAlligatorBastard = new Animal();
            Gator gator = new Gator();
            Alligatoridae gatorGenus = new Alligatoridae();

            dirtyAlligatorBastard.species = gator;
            dirtyAlligatorBastard.genus = gatorGenus;

            dirtyAlligatorBastard.name = "The Stupid Alligator";

            List<Animal> pets = new List<Animal>();

            pets.Add(myOnlyFriend);
            pets.Add(annoyingSquirrel);
            pets.Add(dirtyAlligatorBastard);

            foreach(Animal animal in pets)
            {
                Console.WriteLine($"{animal.name} inside of our foreach loop\r\n");
            }

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
