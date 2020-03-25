using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    abstract class Animal
    {
        // ATTRIBUTES
        public virtual int Age { get; set; } = 0;
        public int Legs { get; set; } = 4;
        public abstract string Noise { get; set; }

        // BEHAVIORS
        public virtual string Eat()
        {
            Console.WriteLine("CHOMP CHOMP CHOMP");
            return $"My favorite food is generic mush.";
        }

        public string MakeNoise()
        {
            Console.WriteLine(this.Noise, this.Noise, this.Noise);
            return $"The {this.GetType()} says: {this.Noise}. What a racket!";
        }
    }
}
