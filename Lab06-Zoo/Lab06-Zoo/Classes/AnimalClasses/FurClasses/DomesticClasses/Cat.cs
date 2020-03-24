using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses.DomesticClasses
{
    // Concrete Class, 
    // Based on Domestic
    // Can be instantiated
    public class Cat : Domestic
    {
        public string CollarColor { get; set; }
        /// <summary>
        /// Cat class constructor. sets species and sound properties
        /// </summary>
        public Cat()
        {
            this.Species = "Siamese Cat";
            this.Sound = "Reowrr!";
        }
    }
}
