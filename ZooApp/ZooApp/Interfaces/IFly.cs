using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Interfaces
{
    interface IFly
    {
        public int Wingspan { get; set; }
        public int Altitude { get; set; }
        
        /// <summary>
        /// The animal climbs higher in the sky
        /// </summary>
        /// <param name="Wingspan">the animals wingspan</param>
        /// <returns>their altitude after climbing</returns>
        int Climb(int Wingspan);

        /// <summary>
        /// The animal falls out of the sky
        /// </summary>
        /// <returns>their altitude after falling</returns>
        int Fall();
    }
}
