using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses
{
    // Abstract Class, 
    // Based on Feathered
    // Derived by Duck and Penguin
    // Never directly instantiated
    public class Aquatic : Feathered
    {
        public string Toes = "webbed";
        /// <summary>
        /// returns true if the bird has waterproof feathers.
        /// </summary>
        /// <returns>Boolean can dive underwater</returns>
        public bool Dive()
        {
            return (this.Waterproof);
        }
    }
}
