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
        /// <summary>
        /// A Boa's best defense mechanism is squeezing its prey
        /// </summary>
        public void Squeeze()
        {
            // Boa squeezes
        }

        /// <summary>
        /// Boa class constructor. sets species and sound properties
        /// </summary>
        public Boa()
        {
            this.Species = "Boa Constrictor";
            this.Sound = "HISSSS";
        }
    }
}
