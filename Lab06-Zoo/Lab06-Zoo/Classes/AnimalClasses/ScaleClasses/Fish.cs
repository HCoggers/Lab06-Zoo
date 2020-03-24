using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    public class Fish : Scaled
    {
        public int Fins { get; set; }
        public void Swim()
        {
            // A fish can swim
        }

        public Fish(int fins = 4)
        {
            this.Fins = fins;
        }
    }
}
