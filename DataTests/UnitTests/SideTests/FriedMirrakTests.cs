﻿/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        [Fact]
        public void ShouldBeAnSide()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.SideSize);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.SideSize = Size.Large;
            Assert.Equal(Size.Large, fm.SideSize);
            fm.SideSize = Size.Medium;
            Assert.Equal(Size.Medium, fm.SideSize);
            fm.SideSize = Size.Small;
            Assert.Equal(Size.Small, fm.SideSize);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.SideSize = size;
            Assert.Equal(price, fm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.SideSize = size;
            Assert.Equal(calories, fm.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.SideSize = size;
            Assert.Equal(name, fm.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Size", () => { fm.SideSize = Size.Large; });
            Assert.PropertyChanged(fm, "Size", () => { fm.SideSize = Size.Medium; });
            Assert.PropertyChanged(fm, "Size", () => { fm.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Price", () => { fm.SideSize = Size.Large; });
            Assert.PropertyChanged(fm, "Price", () => { fm.SideSize = Size.Medium; });
            Assert.PropertyChanged(fm, "Price", () => { fm.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.PropertyChanged(fm, "Calories", () => { fm.SideSize = Size.Large; });
            Assert.PropertyChanged(fm, "Calories", () => { fm.SideSize = Size.Medium; });
            Assert.PropertyChanged(fm, "Calories", () => { fm.SideSize = Size.Small; });
        }
    }
}