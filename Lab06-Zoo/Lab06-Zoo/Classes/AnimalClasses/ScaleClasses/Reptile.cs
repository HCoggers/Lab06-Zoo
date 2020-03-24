using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Abstract Class, 
    // Based on Scaled
    // Derived by Boa and Salamander
    // Never directly instantiated
    public abstract class Reptile : Scaled
    {
        public int Teeth = 1000;
    }
}
