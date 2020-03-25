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
        public virtual string DoMagic()
        {
            return "twinkle, twinkle!";
        }

        public int Climb(int Wingspan)
        {
            Altitude += 2 * Wingspan;
            return Altitude;
        }

        public int Fall()
        {
            Altitude -= 50;
            return Altitude;
        }
    }
}
