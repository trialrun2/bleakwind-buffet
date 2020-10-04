/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843, (double)dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (!includeBun)
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
            }
            if (!includeLettuce)
            {
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            }
            if (!includeMayo)
            {
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            }
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese &&
                includeTomato && includeLettuce && includeMayo)
            {
                Assert.Empty(dd.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () => { dd.Bun = false; });
            Assert.PropertyChanged(dd, "Bun", () => { dd.Bun = true; });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () => { dd.Ketchup = false; });
            Assert.PropertyChanged(dd, "Ketchup", () => { dd.Ketchup = true; });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () => { dd.Mustard = false; });
            Assert.PropertyChanged(dd, "Mustard", () => { dd.Mustard = true; });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () => { dd.Pickle = false; });
            Assert.PropertyChanged(dd, "Pickle", () => { dd.Pickle = true; });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () => { dd.Cheese = false; });
            Assert.PropertyChanged(dd, "Cheese", () => { dd.Cheese = true; });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () => { dd.Lettuce = false; });
            Assert.PropertyChanged(dd, "Lettuce", () => { dd.Lettuce = true; });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () => { dd.Tomato = false; });
            Assert.PropertyChanged(dd, "Tomato", () => { dd.Tomato = true; });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () => { dd.Mayo = false; });
            Assert.PropertyChanged(dd, "Mayo", () => { dd.Mayo = true; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Cheese = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Cheese = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Pickle = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Pickle = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Mustard = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Mustard = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Ketchup = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Ketchup = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Bun = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Bun = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Lettuce = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Lettuce = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Tomato = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Tomato = true; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Mayo = false; });
            Assert.PropertyChanged(dd, "SpecialInstructions", () => { dd.Mayo = true; });
        }
    }
}