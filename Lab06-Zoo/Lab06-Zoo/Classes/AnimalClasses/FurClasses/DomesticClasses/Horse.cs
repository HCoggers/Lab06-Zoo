using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses.DomesticClasses
{
    // Concrete Class, 
    // Based on Domestic
    // Can be instantiated
    public class Horse : Domestic
    {
        public bool Shoed { get; set; }
        /// <summary>
        /// Horse class constructor. sets species and sound properties
        /// </summary>
        public Horse()
        {
            this.Species = "bald Unicorn";
            this.Sound = "NYEEEEEE-EE-AY!";
        }
    }
}
