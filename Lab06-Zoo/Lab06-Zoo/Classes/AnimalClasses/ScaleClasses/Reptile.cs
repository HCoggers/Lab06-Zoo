using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    public class Reptile : Scaled
    {
        public int Teeth { get; set; }
        public Reptile(int teeth = 1000)
        {
            this.Teeth = teeth;
        }
    }
}
