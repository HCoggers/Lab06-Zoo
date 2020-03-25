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

        /// <summary>
        /// The bear catches fish based on its age
        /// </summary>
        /// <returns>The number of fish caught</returns>
        public int CatchFish()
        {
            if (this.Age <= 10)
                return 3 * Age;
            else
                return 40 - Age;
        }
    }
}
