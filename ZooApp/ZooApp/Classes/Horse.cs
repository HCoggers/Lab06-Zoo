using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Horse : Domestic
    {
        public override string Name { get; set; } = "This Horse has no name";
        public override string Noise { get; set; } = "Neigh!";

        public Horse(string name)
        {
            Name = name;
        }
    }
}
