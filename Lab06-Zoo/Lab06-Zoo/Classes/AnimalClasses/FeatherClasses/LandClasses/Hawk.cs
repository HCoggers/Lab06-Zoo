using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.LandClasses
{
    // Concrete Class, 
    // Based on Land
    // Can be instantiated
    public class Hawk : Land
    {
        public bool SymbolOfCoolness = true;
        /// <summary>
        /// Hawk class constructor. sets species and sound properties
        /// </summary>
        public Hawk()
        {
            this.Species = "Red-Tailed Hawk";
            this.Sound = "*Echoing shriek*";
        }
    }
}
