using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FurClasses
{
    public class Domestic : Furred
    {
        public string Name { get; set; }
        public Domestic(string name = "unnamed")
        {
            this.Name = name;

        }
    }
}
