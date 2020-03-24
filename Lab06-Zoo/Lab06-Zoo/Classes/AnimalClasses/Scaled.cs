using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    public class Scaled : Animal
    {
        public bool ColdBlooded = true;
        public Scaled LayEgg(Scaled parent1, Scaled parent2)
        {
            return new Scaled { Parents = new Scaled[2] { parent1, parent2 } };
        }
    }
}
