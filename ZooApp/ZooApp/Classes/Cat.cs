using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Cat : Domestic
    {
        // ATTRIBUTES
        public bool HasConeOfShame = false;
        public override string Noise { get; set; } = "Meow!";

        /// <summary>
        /// Summarized in Class Domestic
        /// </summary>
        public override string TrainWith(string trainer)
        {
            if (Owner == trainer)
                return $"{Name} learned to sit.";
            return "It didn't wanna";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Cat's name</param>
        public Cat(string name)
        {
            Name = name;
        }
    }
}
