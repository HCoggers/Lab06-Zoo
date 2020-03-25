using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Interfaces
{
    interface ISwim
    {
        public int BreathTime { get; set; }
        void Dive(int breath);
        void TreadWater();
        void TryATry();
    }
}
