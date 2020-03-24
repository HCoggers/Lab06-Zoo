using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.AquaticClasses
{
    // Concrete Class, 
    // Based on Aquatic
    // Can be instantiated
    public class Penguin : Aquatic
    {
        public bool blubber = true;
        /// <summary>
        /// Penguin class constructor. sets species and sound properties
        /// </summary>
        public Penguin()
        {
            this.Species = "Emporor";
            this.Sound = "BRRRRRrrrr";
        }
    }
}
