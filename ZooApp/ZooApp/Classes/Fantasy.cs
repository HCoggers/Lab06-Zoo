using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Fantasy : Animal
    {
        // ATTRIBUTES
        public virtual bool IsMagic { get; set; } = false;
        public abstract int Atk { get; set; }
        public abstract int Def { get; set; }

        // BEHAVIOR
        public virtual string DoMagic()
        {
            return "twinkle, twinkle!";
        }
    }
}
