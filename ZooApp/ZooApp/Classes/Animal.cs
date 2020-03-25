using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Classes
{
    public abstract class Animal
    {
        // ATTRIBUTES
        public virtual int Age { get; set; } = 0;
        public int Legs { get; set; } = 4;
        public abstract string Noise { get; set; }

        // BEHAVIORS
        /// <summary>
        /// The animal eats some food
        /// </summary>
        /// <returns>The animal comments on its diet</returns>
        public virtual string Eat()
        {
            Console.WriteLine("CHOMP CHOMP CHOMP");
            return $"My favorite food is generic mush.";
        }

        /// <summary>
        /// The animal makes a noise
        /// </summary>
        /// <returns>a description of the animal's noise</returns>
        public string MakeNoise()
        {
            Console.WriteLine(this.Noise, this.Noise, this.Noise);
            return $"It says: {this.Noise}. What a racket!";
        }
    }
}
