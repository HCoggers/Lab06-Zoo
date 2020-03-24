using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses
{
    // Abstract Class, 
    // Based on Furred
    // Derived by Giraffe and Wolf
    // Never directly instantiated
    public abstract class Wild : Furred
    {
        public bool IsPredator = true;
    }
}
