﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    class Phoenix : Fantasy
    {
        // ATTRIBUTES
        public override int Atk { get; set; } = 200;
        public override int Def { get; set; } = 1000;
        public override string Noise { get; set; } = "Karoo!";

        public override int Age { get; set; } = Int32.MaxValue;

        // BEHAVIORS
        public override string DoMagic()
        {
            Age++;
            Console.WriteLine($"Your phoenix is {Age} years old.");
            return $"FLAMES!!!!... and a baby {Age}-year old phoenix!";
        }

    }
}