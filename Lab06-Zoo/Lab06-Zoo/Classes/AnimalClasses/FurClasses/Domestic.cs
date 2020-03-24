using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses
{
    // Abstract Class, 
    // Based on Furred
    // Derived by Horse and Cat
    // Never directly instantiated
    public abstract class Domestic : Furred
    {
        public string Name = "unnamed";
    }
}
