using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.AquaticClasses
{
    // Concrete Class, 
    // Based on Aquatic
    // Can be instantiated
    public class Duck : Aquatic
    {
        public string Personality = "daffy";
        /// <summary>
        /// Duck class constructor. sets species and sound properties
        /// </summary>
        public Duck()
        {
            this.Species = "Mallard";
            this.Sound = "QUACK!!!";
        }
    }
}
