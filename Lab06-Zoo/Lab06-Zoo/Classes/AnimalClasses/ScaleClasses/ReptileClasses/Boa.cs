using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses
{
    // Concrete Class, 
    // Based on Reptile
    // Can be instantiated
    public class Boa : Reptile
    {
        public void Squeeze()
        {
            // Boa squeezes
        }
        public Boa()
        {
            this.Species = "Boa Constrictor";
            this.Sound = "HISSSS";
        }
    }
}
