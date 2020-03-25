using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Snake : Reptile
    {
        // ATTRIBUTES
        public bool Venomous = true;
        public override string Noise { get; set; } = "Ssssss";
        public override string Habitat { get; set; } = "Grass";
        public override int FoodChainIndex { get; set; } = 1;

        public override int TailLength { get; set; } = 100;

        /// <summary>
        /// Summarized in class Reptile
        /// </summary>
        public override int LayEggs()
        {
            return TailLength / 3;
        }

    }
}
