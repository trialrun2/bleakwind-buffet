/*
 * Author: Zane Myers
 * Class name: WarriorWaterTests.cs
 * Purpose: Test class for warrior water
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
            }
            if (includeLemon)
            {
                Assert.Contains("Add lemon", ww.SpecialInstructions);
            }
            if (!includeLemon && includeIce)
            {
                Assert.Empty(ww.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Large; });
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Medium; });
            Assert.PropertyChanged(ww, "Size", () => { ww.Size = Size.Small; });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () => { ww.Ice = false; });
            Assert.PropertyChanged(ww, "Ice", () => { ww.Ice = true; });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Lemon", () => { ww.Lemon = false; });
            Assert.PropertyChanged(ww, "Lemon", () => { ww.Lemon = true; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Lemon = false; });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Lemon = true; });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Ice = false; });
            Assert.PropertyChanged(ww, "SpecialInstructions", () => { ww.Ice = true; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }
    }
}
