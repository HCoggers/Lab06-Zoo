using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public class Horse : Domestic, IFly, ISwim
    {
        // ATTRIBUTES
        public override string Noise { get; set; } = "Neigh!";
        public int GallopSpeed { get; set; } = 100;
        public int Wingspan { get; set; } = 80;
        public int Altitude { get; set; } = 0;
        public int BreathTime { get; set; } = 300;

        // BEHAVIORS

        /// <summary>
        /// Summarized in class Domestic
        /// </summary>
        public override string TrainWith(string trainer)
        {
            if (Owner == trainer)
            {
                GallopSpeed++;
                return $"{Name} got a little faster.";
            }

            return "It didn't wanna";
        }


        /// <summary>
        /// Summarized in interface IFly
        /// </summary>
        public int Climb(int Wingspan)
        {
            Altitude += Wingspan / 2;
            return Altitude;
        }

        /// <summary>
        /// Summarized in interface IFly
        /// </summary>
        public int Fall()
        {
            Altitude -= 100;
            return Altitude;
        }

        /// <summary>
        /// Summarized in interface ISwim
        /// </summary>
        public int Dive(int breath)
        {
            Console.WriteLine("This Horse can't dive more than 2 feet.");
            return 2;
        }

        /// <summary>
        /// Summarized in interface ISwim
        /// </summary>
        public bool TreadWater()
        {
            Console.WriteLine($"Treads water for {BreathTime}.");
            return true;
        }

        /// <summary>
        /// Horse's constructor
        /// </summary>
        /// <param name="name">This horse's name</param>
        public Horse(string name)
        {
            Name = name;
        }
    }
}
