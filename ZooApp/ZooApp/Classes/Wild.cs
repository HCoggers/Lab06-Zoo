using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Wild : Animal
    {
        // ATTRIBUTES
        public virtual string Diet { get; set; } = "Omnivore";
        public abstract string Habitat { get; set; }
        public abstract int FoodChainIndex { get; set; }

        // BEHAVIORS
        /// <summary>
        /// The animal hunts another wild animal
        /// </summary>
        /// <param name="prey">the animal to be hunted</param>
        /// <returns>success message or failure message based on Wild animal food chain index</returns>
        public string Hunt(Wild prey)
        {
            if (prey.FoodChainIndex < this.FoodChainIndex)
                return "A successful hunt! Yum!";
            else
                return "Darn, it got away!";
        }

        /// <summary>
        /// Summarized in class Animal
        /// </summary>
        public sealed override string Eat()
        {
            Console.WriteLine("CHOMP CHOMP CHOMP");
            switch (Diet)
            {
                case "Omnivore":
                    return $"My favorite food is ABSOLUTELY EVERYTHING.";
                case "Carnivore":
                    return $"I'm a Meat-Lover for sure!";
                case "Herbivore":
                    return $"Do you have any vegan options?";
            }
            return base.Eat();
        }
    }
}
