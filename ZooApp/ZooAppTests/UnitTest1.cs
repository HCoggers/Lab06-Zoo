using System;
using Xunit;
using ZooApp.Classes;

namespace ZooAppTests
{
    public class UnitTest1
    {
        // LAB 6 TESTS
        #region
        // WELD REPTILE TESTS
        [Fact]
        public void SnakeExhibitsReptileBEhavior()
        {
            Snake snek = new Snake();
            Assert.Equal(1000, snek.ScaleCount);
        }
        [Fact]
        public void SnakeExhibitsWildBehavior()
        {
            Snake snek = new Snake();
            Assert.IsType<string>(snek.Hunt(new Bear()));
        }
        [Fact]
        public void CrocodileExhibitsWildBehavior()
        {
            Crocodile crikey = new Crocodile();
            Assert.True(crikey.Diet == "Carnivore");
        }
        [Fact]
        public void CrocodileExhibitsAnimalBehavior()
        {
            Crocodile crikey = new Crocodile();
            Assert.Equal(4, crikey.Legs);
        }

        // WILD MAMMAL TESTS
        [Fact]
        public void BearExhibitsMammalTraits()
        {
            Bear smokey = new Bear();
            Assert.Equal("Brown", smokey.FurColor);
        }
        [Fact]
        public void BearExhibitsAnimalBehavior()
        {
            Bear smokey = new Bear();
            Assert.IsType<string>(smokey.Noise);
        }

        // DOMESTIC ANIMAL TESTS
        [Fact]
        public void CatExhibitsDomesticBehavior()
        {
            Cat mungojerrie = new Cat("MungoJerrie");
            Assert.True(mungojerrie.Owner == "You");
        }

        [Fact]
        public void CatExhibitsAnimalBehavior()
        {
            Cat rumpleteaser = new Cat("RumpleTeaser");
            Assert.IsType<string>(rumpleteaser.Eat());
        }

        [Fact]
        public void HorseExhibitsDomesticBehavior()
        {
            Horse shadowfax = new Horse("Shadowfax");
            Assert.IsType<string>(shadowfax.TrainWith("You"));
        }

        [Fact]
        public void HorseExhibitsAnimalBehavior()
        {
            Horse pinkiepie = new Horse("Pinkie Pie");
            Assert.Equal(0, pinkiepie.Age);
        }

        // FANTASY ANIMAL TESTS

        [Fact]
        public void DragonExhibitsFantasyBehavior()
        {
            Dragon smaug = new Dragon();
            Assert.IsType<string>(smaug.DoMagic());
        }

        [Fact]
        public void DragonExhibitsAnimalBehavior()
        {
            Dragon spike = new Dragon();
            Assert.Equal("It says: ROAR. What a racket!", spike.MakeNoise());
        }

        [Fact]
        public void PhoenixExhibitsFantasyBehavior()
        {
            Phoenix fawkes = new Phoenix();
            Assert.Equal(200, fawkes.Atk);
        }

        [Fact]
        public void PhoenixExhibitsAnimalBehavior()
        {
            Phoenix fawkes = new Phoenix();
            fawkes.DoMagic();
            Assert.Equal(Int32.MinValue, fawkes.Age);

        }
        #endregion

        // LAB 7 TESTS
        #region
        [Fact]
        public void Test()
        {

        }
        #endregion
    }
}
