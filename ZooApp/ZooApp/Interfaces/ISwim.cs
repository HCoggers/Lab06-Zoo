using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Interfaces
{
    interface ISwim
    {
        public int BreathTime { get; set; }
        int Dive(int breath);
        bool TreadWater();
    }
}
