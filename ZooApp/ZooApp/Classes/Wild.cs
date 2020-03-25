using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Wild : Animal
    {
        // ATTRIBUTES
        public virtual string Diet { get; set; } = "Omnivore";
        public abstract string Habitat { get; set; }
        public abstract int FoodChainIndex { get; set; }

        // BEHAVIORS
        public string Hunt(Wild prey)
        {
            if (prey.FoodChainIndex < this.FoodChainIndex)
                return "A successful hunt! Yum!";
            else
                return "Darn, it got away!";
        }

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
