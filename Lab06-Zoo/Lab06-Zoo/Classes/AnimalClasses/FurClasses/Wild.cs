using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses
{
    public class Wild : Furred
    {
        public bool IsPredator { get; set; }
        public Wild(bool predator = true)
        {
            this.IsPredator = predator;
        }
    }
}
