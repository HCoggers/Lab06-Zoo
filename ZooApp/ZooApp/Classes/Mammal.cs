using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Mammal : Wild
    {
        // ATTRIBUTES
        public string FurColor = "Brown";
        public override string Habitat { get; set; } = "Woods";

        // BEHAVIORS
        /// <summary>
        /// The Animal Hibernates for a given number of hours
        /// </summary>
        /// <param name="hours">number of hours to hibernate</param>
        /// <returns>The sound a hibernating animal makes</returns>
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
