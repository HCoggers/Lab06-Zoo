using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public class Dragon : Fantasy
    {
        // ATTRIBUTES
        public override int Atk { get; set; } = 500;
        public override int Def { get; set; } = 500;
        public override string Noise { get; set; } = "ROAR";
        public override bool IsMagic { get; set; } = false;
        public override int Wingspan { get; set; } = 200;
    }
}
