using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Domestic : Animal
    {
        // ATTRIBUTES
        public string Name { get; set; }
        public virtual string Owner { get; set; } = "You";

        // Behaviors
        public abstract string TrainWith(string trainer);

    }
}
