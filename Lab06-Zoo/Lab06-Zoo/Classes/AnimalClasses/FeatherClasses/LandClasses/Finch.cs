using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.LandClasses
{
    // Concrete Class, 
    // Based on Land
    // Can be instantiated
    public class Finch : Land
    {
        public string CheekShape = "pudgy";
        /// <summary>
        /// Finch class constructor. sets species and sound properties
        /// </summary>
        public Finch()
        {
            this.Species = "Goldfinch";
            this.Sound = "jibberjabberjibberjabberjibberjabberjibberjabber...";
        }
    }
}
