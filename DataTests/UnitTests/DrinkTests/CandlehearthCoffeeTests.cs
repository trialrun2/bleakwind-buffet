/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(chc);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.CupSize);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.CupSize = Size.Large;
            Assert.Equal(Size.Large, chc.CupSize);
            chc.CupSize = Size.Medium;
            Assert.Equal(Size.Medium, chc.CupSize);
            chc.CupSize = Size.Small;
            Assert.Equal(Size.Small, chc.CupSize);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.CupSize = size;
            Assert.Equal(price, chc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.CupSize = size;
            Assert.Equal(cal, chc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = includeIce;
            chc.RoomForCream = includeCream;
            if (includeIce)
            {
                Assert.Contains("Add ice", chc.SpecialInstructions);
            }
            if (includeCream)
            {
                Assert.Contains("Add cream", chc.SpecialInstructions);
            }
            if(!includeCream && !includeIce)
            {
                Assert.Empty(chc.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = decaf;
            chc.CupSize = size;
            Assert.Equal(name, chc.ToString());
        }
    }
}
