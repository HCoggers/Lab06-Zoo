using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public abstract class Reptile : Wild, ISwim
    {
        // ATTRIBUTES
        public int ScaleCount { get; set; } = 1000;
        public abstract int TailLength { get; set; }
        public override string Diet { get; set; } = "Carnivore";
        public int BreathTime { get; set; } = 360;


        // BEHAVIORS

        /// <summary>
        /// The animal lays eggs
        /// </summary>
        /// <returns>the number of eggs it lays</returns>
        public abstract int LayEggs();

        /// <summary>
        /// Summarized in interface ISwim
        /// </summary>
        public int Dive(int breath)
        {
            Console.WriteLine($"Dove down { BreathTime / 10} feet.");
            return BreathTime / 10;
        }


        /// <summary>
        /// Summarized in interface ISwim
        /// </summary>
        public bool TreadWater()
        {
            Console.WriteLine($"Treads water for {BreathTime} seconds.");
            return true;
        }
    }
}
