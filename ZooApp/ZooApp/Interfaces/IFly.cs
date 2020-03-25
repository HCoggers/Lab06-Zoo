using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Interfaces
{
    interface IFly
    {
        public int Wingspan { get; set; }
        public int Altitude { get; set; }
        
        int Climb(int Wingspan);
        int Fall();
    }
}
