using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Reptile : Wild
    {
        // ATTRIBUTES
        public int ScaleCount { get; set; } = 1000;
        public abstract int TailLength { get; set; }
        public override string Diet { get; set; } = "Carnivore";

        // BEHAVIORS
        public int LayEggs( int nestSize )
        {
            return 3 * nestSize;
        }
    }
}
