using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Concrete Class, 
    // Based on Fish
    // Can be instantiated
    public class Shark : Fish
    {
        public string Diet = "carnivorous";
        /// <summary>
        /// Shark class constructor. sets species and sound properties
        /// </summary>
        public Shark()
        {
            this.Species = "Great White Shark";
            this.Sound = "Dun-DUN Dun-DUN...";
        }
    }
}
