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
    }
}
