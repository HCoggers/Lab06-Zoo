using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Zoo.Classes.AnimalClasses.FeatherClasses
{
    public class Land : Feathered
    {
        public bool IsBirdOfPrey { get; set; }

        public Land(bool birdofprey = true)
        {
            this.IsBirdOfPrey = birdofprey;
        }
    }
}
