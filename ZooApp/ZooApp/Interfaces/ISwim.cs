using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Interfaces
{
    interface ISwim
    {
        public int BreathTime { get; set; }

        /// <summary>
        /// The Animal Dives Underwater
        /// </summary>
        /// <param name="breath">The time in seconds the animal can hold its breath</param>
        /// <returns>the depth the animal dived too</returns>
        int Dive(int breath);

        /// <summary>
        /// The animal treads water for a given breath capacity
        /// </summary>
        /// <returns>the time the animal was able to tread</returns>
        bool TreadWater();
    }
}
