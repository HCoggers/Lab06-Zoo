using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    // Abstract Base Class, 
    // Derived by Feathered, Scaled, and Furred classes
    // Never directly instantiated
    public abstract class Animal
    {
        public int Age = 0;
        public string Habitat = "nest";
        public int Legs = 4;
        public int Weight { get; set; }
        public Animal[] Parents = new Animal[2];
        public string Sound { get; set; }
        public string Species { get; set; }

        /// <summary>
        /// prints the animal's sound to the console
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine($"{this.Sound}");
        }
    }
}
