using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Mammal : Wild
    {
        // ATTRIBUTES
        public string FurColor = "Brown";
        public override string Habitat { get; set; } = "Woods";

        // BEHAVIORS
        public string Hibernate(int hours)
        {
            string snooze = "Zzz";
            for(int i = 0; i < hours; i++)
            {
                snooze += "zz";
            }
            Console.WriteLine(snooze);
            return snooze;
        }
    }
}
