using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Crocodile : Reptile
    {
        // ATTRIBUTES
        public override string Noise { get; set; } = "*sneaky log lizard noise*";
        public override string Habitat { get; set; } = "River";
        public override int FoodChainIndex { get; set; } = 3;
        public override int TailLength { get; set; } = 50;

        // BEHAVIORS
        public string DisguiseAsLog()
        {
            return "It's always disguised.";
        }
    }
}
