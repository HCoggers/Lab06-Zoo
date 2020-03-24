using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    // Abstract Class, 
    // Based on Animal
    // Derived by Aquatic and Land
    // Never directly instantiated
    public class Feathered : Animal
    {
        public string BeakShape = "hooked";
        public bool Waterproof = true;
    }
}
