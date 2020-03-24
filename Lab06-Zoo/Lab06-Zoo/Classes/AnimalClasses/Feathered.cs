using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes
{
    public class Feathered : Animal
    {
        public string BeakShape = "hooked";
        public Feathered LayEgg(Feathered parent1, Feathered parent2)
        {
            return new Feathered { Parents = new Feathered[] { parent1, parent2 } };
        }
    }
}
