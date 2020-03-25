using System;
using ZooApp.Classes;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProveAnimalBehavior();
        }

        /// <summary>
        /// Test Out Every class in this repo
        /// </summary>
        static void ProveAnimalBehavior()
        {
            // Use polymorphism to create base class arrays with concrete class objects
            Animal[] zooPopulation = new Animal[]
            {
                new Snake(),
                new Crocodile(),
                new Bear(),
                new Cat("Carl"),
                new Horse("Harold"),
                new Dragon(),
                new Phoenix()
            };

            Reptile[] slithers = new Reptile[2];
            Domestic[] pets = new Domestic[2];

            // Demonstrate Animal Methods
            Console.WriteLine("All Animals Make Noise, and Like to eat!");
            foreach (Animal creature in zooPopulation)
            {
                Console.WriteLine("Press a key to hear the next one...");
                Console.ReadLine();
                creature.MakeNoise();
                creature.Eat();
                Console.WriteLine();
            }

            // Explicitly cast Animals to Wild type array
            Wild[] wilds = new Wild[]
            {
                (Wild)zooPopulation[0],
                (Wild)zooPopulation[1],
                (Wild)zooPopulation[2]
            };

            // Demonstrate Wild Method
            foreach (Wild creature in wilds)
                creature.Hunt((Wild)zooPopulation[1]);

            // Demonstrate Mammal and Reptile Methods
            Console.WriteLine($"Crocodiles lay { new Crocodile().LayEggs()} eggs.");
            Console.WriteLine($"Snakes lay { new Snake().LayEggs()} eggs.");
            Console.WriteLine();
            Console.WriteLine("...and bears hibernate:");
            new Bear().Hibernate(24);
            Console.WriteLine();

            // Demonstrate Domestic Behavior
            Console.WriteLine("Domestic animals can be trained by their owners:");
            Console.WriteLine(new Cat("Jerry Cat").TrainWith("You"));
            Console.WriteLine(new Horse("Apple Jack").TrainWith("You"));
            Console.WriteLine();

            // Demonstrate Fantasy Behavior
            Console.WriteLine("Fantasy creatures have magical powers!");
            Console.WriteLine(new Dragon().DoMagic());
            Console.WriteLine(new Phoenix().DoMagic());
            Console.WriteLine("Age is kind of a joke to immortal phoenixes");
        }
    }
}
