using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Phoenix : Fantasy
    {
        // ATTRIBUTES
        public override int Atk { get; set; } = 200;
        public override int Def { get; set; } = 1000;
        public override string Noise { get; set; } = "Karoo!";

        public override int Age { get; set; } = Int32.MaxValue;

        // BEHAVIORS
        public string Rebirthe()
        {
            return "FLAMES!!!!... and a baby phoenix!";
        }

    }
}
