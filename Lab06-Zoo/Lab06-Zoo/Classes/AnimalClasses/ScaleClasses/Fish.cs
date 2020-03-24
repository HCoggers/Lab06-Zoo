using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Abstract Class, 
    // Based on Scaled
    // Derived by LionFish and Shark
    // Never directly instantiated
    public abstract class Fish : Scaled
    {
        public int Fins = 4;
        /// <summary>
        /// Returns true if a fish is cold-blooded.
        /// </summary>
        public bool CanSwim()
        {
            return (this.ColdBlooded);
        }
    }
}
