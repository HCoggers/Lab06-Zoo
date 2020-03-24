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
        public Salamander()
        {
            this.Species = "Salamander";
            this.Sound = "...";
        }
    }
}
