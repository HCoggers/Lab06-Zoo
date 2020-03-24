
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses.WildClasses
{
    // Concrete Class, 
    // Based on Wild
    // Can be instantiated
    public class Giraffe : Wild
    {
        public int NeckLength { get; set; }
        /// <summary>
        /// Giraffe class constructor. sets species and sound properties
        /// </summary>
        public Giraffe()
        {
            this.Species = "Speckled Giraffe";
            this.Sound = "*it's head is too far away to hear*";
        }
    }
}
