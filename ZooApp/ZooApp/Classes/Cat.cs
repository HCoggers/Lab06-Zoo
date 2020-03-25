using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Cat : Domestic
    {
        // ATTRIBUTES
        public bool HasConeOfShame = false;
        public override string Noise { get; set; } = "Meow!";
        public override string Name { get; set; } = "This cat has no name.";

        // Constructor
        public Cat(string name)
        {
            Name = name;
        }
    }
}
