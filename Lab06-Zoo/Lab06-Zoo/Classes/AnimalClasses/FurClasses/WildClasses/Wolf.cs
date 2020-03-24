using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses.WildClasses
{
    // Concrete Class, 
    // Based on Wild
    // Can be instantiated
    public class Wolf : Wild
    {
        public Wolf[] Pack { get; set; }
        /// <summary>
        /// Wolf class constructor. sets species and sound properties
        /// </summary>
        public Wolf()
        {
            this.Species = "Dire Wolf";
            this.Sound = "How-oooooooohh!";
        }
    }
}
