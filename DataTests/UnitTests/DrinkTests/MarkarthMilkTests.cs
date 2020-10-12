/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.CupSize);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.CupSize = Size.Large;
            Assert.Equal(Size.Large, mm.CupSize);
            mm.CupSize = Size.Medium;
            Assert.Equal(Size.Medium, mm.CupSize);
            mm.CupSize = Size.Small;
            Assert.Equal(Size.Small, mm.CupSize);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.CupSize = size;
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.CupSize = size;
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce)
            {
                Assert.Contains("Add ice", mm.SpecialInstructions);
            }
            else
            {
                Assert.Empty(mm.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.CupSize = size;
            Assert.Equal(name, mm.ToString());
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Size", () => { mm.CupSize = Size.Large; });
            Assert.PropertyChanged(mm, "Size", () => { mm.CupSize = Size.Medium; });
            Assert.PropertyChanged(mm, "Size", () => { mm.CupSize = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Price", () => { mm.CupSize = Size.Large; });
            Assert.PropertyChanged(mm, "Price", () => { mm.CupSize = Size.Medium; });
            Assert.PropertyChanged(mm, "Price", () => { mm.CupSize = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Calories", () => { mm.CupSize = Size.Large; });
            Assert.PropertyChanged(mm, "Calories", () => { mm.CupSize = Size.Medium; });
            Assert.PropertyChanged(mm, "Calories", () => { mm.CupSize = Size.Small; });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "Ice", () => { mm.Ice = true; });
            Assert.PropertyChanged(mm, "Ice", () => { mm.Ice = false; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.PropertyChanged(mm, "SpecialInstructions", () => { mm.Ice = true; });
            Assert.PropertyChanged(mm, "SpecialInstructions", () => { mm.Ice = false; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }
    }
}