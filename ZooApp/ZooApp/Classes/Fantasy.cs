using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Fantasy : Animal
    {
        // ATTRIBUTES
        public virtual bool IsMagic { get; set; } = true;
        public abstract int Atk { get; set; }
        public abstract int Def { get; set; }

        // BEHAVIOR
        public virtual string DoMagic()
        {
            return "twinkle, twinkle!";
        }
    }
}
