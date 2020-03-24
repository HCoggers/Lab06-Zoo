using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    // Abstract Class, 
    // Based on Animal
    // Derived by Fish and Reptiles
    // Never directly instantiated
    public abstract class Scaled : Animal
    {
        public bool ColdBlooded = true;
    }
}
