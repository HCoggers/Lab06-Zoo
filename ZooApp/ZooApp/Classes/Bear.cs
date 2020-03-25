using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Bear : Mammal
    {
        // ATTRIBUTES
        public override string Noise { get; set; } = "Grawr";
        public override int FoodChainIndex { get; set; } = 2;

        // BEHAVIORS
        public int CatchFish()
        {
            if (this.Age <= 10)
                return 3 * Age;
            else
                return 40 - Age;
        }
    }
}
