using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Interfaces;

namespace ZooApp.Classes
{
    public abstract class Fantasy : Animal, IFly
    {
        // ATTRIBUTES
        public virtual bool IsMagic { get; set; } = true;
        public abstract int Atk { get; set; }
        public abstract int Def { get; set; }
        public abstract int Wingspan { get; set; }
        public int Altitude { get; set; } = 0;

        // BEHAVIOR

        /// <summary>
        /// The Animal does some magic
        /// </summary>
        /// <returns>the sound of magic</returns>
        public virtual string DoMagic()
        {
            return "twinkle, twinkle!";
        }

        /// <summary>
        /// Summarized in interface IFly
        /// </summary>
        public int Climb(int Wingspan)
        {
            Altitude += 2 * Wingspan;
            return Altitude;
        }


        /// <summary>
        /// Summarized in interface IFly
        /// </summary>
        public int Fall()
        {
            Altitude -= 50;
            return Altitude;
        }
    }
}
