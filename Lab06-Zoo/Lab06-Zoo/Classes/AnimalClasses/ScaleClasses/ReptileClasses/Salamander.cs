using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Concrete Class, 
    // Based on Reptile
    // Can be instantiated
    public class Salamander : Reptile
    {
        public bool CanSwim = true;
        /// <summary>
        /// Salamander class constructor. sets species and sound properties
        /// </summary>
        public Salamander()
        {
            this.Species = "Salamander";
            this.Sound = "...";
        }
    }
}
