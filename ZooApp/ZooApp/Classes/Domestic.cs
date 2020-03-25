using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Domestic : Animal
    {
        // ATTRIBUTES
        public abstract string Name { get; set; }
        public virtual string Owner { get; set; } = "You";

        // Behaviors
        public string TrainWith(string trainer)
        {
            if (trainer == this.Owner)
                return "Success! They learned to sit";
            return "They didn't want to learn";
        }
    }
}
