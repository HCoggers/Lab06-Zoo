using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Concrete Class, 
    // Based on Fish
    // Can be instantiated
    public class LionFish : Fish
    {
        public bool venomous = true;
        /// <summary>
        /// LionFish class constructor. sets species and sound properties
        /// </summary>
        public LionFish()
        {
            this.Species = "Red Lionfish";
            this.Sound = "blub.. blub..";
        }
    }

}
