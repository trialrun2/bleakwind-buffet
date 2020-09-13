/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(df);
        }

        [Fact]
        public void ShouldBeAnSide()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(df);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, df.SideSize);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.SideSize = Size.Large;
            Assert.Equal(Size.Large, df.SideSize);
            df.SideSize = Size.Medium;
            Assert.Equal(Size.Medium, df.SideSize);
            df.SideSize = Size.Small;
            Assert.Equal(Size.Small, df.SideSize);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Empty(df.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.SideSize = size;
            Assert.Equal(price, df.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.SideSize = size;
            Assert.Equal(calories, df.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.SideSize = size;
            Assert.Equal(name, df.ToString());
        }
    }
}