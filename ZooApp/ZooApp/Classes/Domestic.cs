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

        /// <summary>
        /// The Animal improves their skills with their owner
        /// </summary>
        /// <param name="trainer">preferably the owner of the animal</param>
        /// <returns>success or failure message</returns>
        public abstract string TrainWith(string trainer);

    }
}
