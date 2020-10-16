/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */

using System;

using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Flavor.Cherry, ss.SodaFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = false;
            Assert.False(ss.Ice);
            ss.Ice = true;
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.SodaFlavor = Flavor.Blackberry;
            Assert.Equal(Flavor.Blackberry, ss.SodaFlavor);
            ss.SodaFlavor = Flavor.Grapefruit;
            Assert.Equal(Flavor.Grapefruit, ss.SodaFlavor);
            ss.SodaFlavor = Flavor.Lemon;
            Assert.Equal(Flavor.Lemon, ss.SodaFlavor);
            ss.SodaFlavor = Flavor.Peach;
            Assert.Equal(Flavor.Peach, ss.SodaFlavor);
            ss.SodaFlavor = Flavor.Watermelon;
            Assert.Equal(Flavor.Watermelon, ss.SodaFlavor);
            ss.SodaFlavor = Flavor.Cherry;
            Assert.Equal(Flavor.Cherry, ss.SodaFlavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce)
            {
                Assert.Contains("Hold ice", ss.SpecialInstructions);
            }
            else
            {
                Assert.Empty(ss.SpecialInstructions);
            }
        }
        
        [Theory]
        [InlineData(Flavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(Flavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(Flavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(Flavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(Flavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(Flavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(Flavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(Flavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(Flavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(Flavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(Flavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(Flavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(Flavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(Flavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(Flavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(Flavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(Flavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(Flavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(Flavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.SodaFlavor = flavor;
            ss.Size = size;
            Assert.Equal(name, ss.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Size", () => { ss.Size = Size.Large; });
            Assert.PropertyChanged(ss, "Size", () => { ss.Size = Size.Medium; });
            Assert.PropertyChanged(ss, "Size", () => { ss.Size = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Price", () => { ss.Size = Size.Large; });
            Assert.PropertyChanged(ss, "Price", () => { ss.Size = Size.Medium; });
            Assert.PropertyChanged(ss, "Price", () => { ss.Size = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Calories", () => { ss.Size = Size.Large; });
            Assert.PropertyChanged(ss, "Calories", () => { ss.Size = Size.Medium; });
            Assert.PropertyChanged(ss, "Calories", () => { ss.Size = Size.Small; });
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Ice", () => { ss.Ice = false; });
            Assert.PropertyChanged(ss, "Ice", () => { ss.Ice = true; });
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Blackberry; });
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Cherry; });
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Grapefruit; });
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Lemon; });
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Peach; });
            Assert.PropertyChanged(ss, "Flavor", () => { ss.SodaFlavor = Flavor.Watermelon; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            SailorSoda ss = new SailorSoda();
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.Ice = false; });
            Assert.PropertyChanged(ss, "SpecialInstructions", () => { ss.Ice = true; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }
    }
}
