/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

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
            Assert.Equal(Size.Small, df.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = Size.Large;
            Assert.Equal(Size.Large, df.Size);
            df.Size = Size.Medium;
            Assert.Equal(Size.Medium, df.Size);
            df.Size = Size.Small;
            Assert.Equal(Size.Small, df.Size);
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
            df.Size = size;
            Assert.Equal(price, df.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(calories, df.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(name, df.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.PropertyChanged(df, "Size", () => { df.Size = Size.Large; });
            Assert.PropertyChanged(df, "Size", () => { df.Size = Size.Medium; });
            Assert.PropertyChanged(df, "Size", () => { df.Size = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.PropertyChanged(df, "Price", () => { df.Size = Size.Large; });
            Assert.PropertyChanged(df, "Price", () => { df.Size = Size.Medium; });
            Assert.PropertyChanged(df, "Price", () => { df.Size = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.PropertyChanged(df, "Calories", () => { df.Size = Size.Large; });
            Assert.PropertyChanged(df, "Calories", () => { df.Size = Size.Medium; });
            Assert.PropertyChanged(df, "Calories", () => { df.Size = Size.Small; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(df);
        }
    }
}