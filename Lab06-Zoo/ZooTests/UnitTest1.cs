using System;
using Xunit;
using Lab06_Zoo;
using Lab06_Zoo.Classes;
using Lab06_Zoo.Classes.AnimalClasses;
using Lab06_Zoo.Classes.AnimalClasses.FurClasses.WildClasses;
using Lab06_Zoo.Classes.AnimalClasses.FurClasses.DomesticClasses;
using Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.AquaticClasses;
using Lab06_Zoo.Classes.AnimalClasses.FeatherClasses.LandClasses;

namespace ZooTests
{
    public class UnitTest1
    {
        // Test that each of your concrete animals exhibit at least 2 appropriate behaviors given to them from a base class.

            // ---- SCALE TESTS ----

        [Fact]
        public void LionFishHasFishBehaviors()
        {
            LionFish fish = new LionFish();
            Assert.True(fish.CanSwim());
        }

        [Fact]
        public void SharkHasScaledBehaviors()
        {
            Shark jaws = new Shark();
            Assert.True(jaws.ColdBlooded);
        }

        [Fact]
        public void BoaHasReptileBehaviors()
        {
            Boa snek = new Boa();
            Assert.Equal(1000, snek.Teeth);
        }

        [Fact]
        public void SalamanderHasAnimalBehaviors()
        {
            Salamander sally = new Salamander();
            Assert.Equal(4, sally.Legs);
        }

        // ---- FUR TESTS ----
        [Fact]
        public void WolfHasWildBehaviors()
        {
            Wolf brody = new Wolf();
            Assert.True(brody.IsPredator);
        }

        [Fact]
        public void GiraffeHasFurBehaviors()
        {
            Giraffe gigi = new Giraffe();
            Assert.Equal("Spotted", gigi.Pattern);
        }
        [Fact]
        public void HorseHasDomesticBehaviors()
        {
            Horse charlie = new Horse();
            Assert.Equal("unnamed", charlie.Name);
        }
        [Fact]
        public void CatHasAnimalBehaviors()
        {
            Cat mungojerrie = new Cat();
            Assert.Equal(0, mungojerrie.Age);
        }

        // ---- FEATHER TESTS ----
        [Fact]
        public void DuckHasAquaticBehaviors()
        {
            Duck donald = new Duck();
            Assert.Equal("webbed", donald.Toes);
        }
        [Fact]
        public void PenguinHasFeatheredBehaviors()
        {
            Penguin oswald = new Penguin();
            Assert.True(oswald.BeakShape == "hooked");
        }
        [Fact]
        public void HawkHasLandBehaviors()
        {
            Hawk hans = new Hawk();
            Assert.True(hans.IsBirdOfPrey);
        }
        [Fact]
        public void FinchHasAnimalBehaviors()
        {
            Finch finnias = new Finch();
            Assert.Equal("nest", finnias.Habitat);
        }

    }
}
