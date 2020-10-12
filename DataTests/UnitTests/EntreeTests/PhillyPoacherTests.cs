/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher dd = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784, (double)pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if (!includeSirloin)
            {
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            }
            if (!includeOnion)
            {
                Assert.Contains("Hold onions", pp.SpecialInstructions);
            }
            if (!includeRoll)
            {
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
            if (includeSirloin && includeOnion && includeRoll)
            {
                Assert.Empty(pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () => { pp.Sirloin = false; });
            Assert.PropertyChanged(pp, "Sirloin", () => { pp.Sirloin = true; });
        }

        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () => { pp.Onion = false; });
            Assert.PropertyChanged(pp, "Onion", () => { pp.Onion = true; });
        }

        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () => { pp.Roll = false; });
            Assert.PropertyChanged(pp, "Roll", () => { pp.Roll = true; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Roll = false; });
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Roll = true; });
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Onion = false; });
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Onion = true; });
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Sirloin = false; });
            Assert.PropertyChanged(pp, "SpecialInstructions", () => { pp.Sirloin = true; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pp);
        }
    }
}