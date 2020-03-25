using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Horse : Domestic
    {
        // ATTRIBUTES
        public override string Noise { get; set; } = "Neigh!";
        public int GallopSpeed { get; set; } = 100;

        // BEHAVIORS
        public override string TrainWith(string trainer)
        {
            if (Owner == trainer)
            {
                GallopSpeed++;
                return $"{Name} got a little faster.";
            }

            return "It didn't wanna";
        }

        public Horse(string name)
        {
            Name = name;
        }
    }
}
