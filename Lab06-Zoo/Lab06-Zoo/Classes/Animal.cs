using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    public class Animal
    {
        public int Age = 0;
        public Animal[] Parents { get; set; }
        public int Legs { get; set; }
        public string Habitat = "nest";

        public Animal(int legs = 4)
        {
            this.Legs = legs;
        }
    }
}
