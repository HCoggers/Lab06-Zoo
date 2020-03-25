using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Crocodile : Reptile
    {
        // ATTRIBUTES
        public override string Noise { get; set; } = "*sneaky log lizard noise*";
        public override string Habitat { get; set; } = "River";
        public override int FoodChainIndex { get; set; } = 3;
        public override int TailLength { get; set; } = 50;

        // BEHAVIORS

        /// <summary>
        /// The animal disguises itself as a log.
        /// </summary>
        /// <returns>It's always disguised.</returns>
        public string DisguiseAsLog()
        {
            return "It's always disguised.";
        }


        /// <summary>
        /// Summarized in class Reptile
        /// </summary>
        public override int LayEggs()
        {
            return 3;
        }

    }
}
