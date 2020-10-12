/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        [Fact]
        public void ShouldBeAnSide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.SideSize);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.SideSize = Size.Large;
            Assert.Equal(Size.Large, vs.SideSize);
            vs.SideSize = Size.Medium;
            Assert.Equal(Size.Medium, vs.SideSize);
            vs.SideSize = Size.Small;
            Assert.Equal(Size.Small, vs.SideSize);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.SideSize = size;
            Assert.Equal(price, vs.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.SideSize = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.SideSize = size;
            Assert.Equal(name, vs.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Size", () => { vs.SideSize = Size.Large; });
            Assert.PropertyChanged(vs, "Size", () => { vs.SideSize = Size.Medium; });
            Assert.PropertyChanged(vs, "Size", () => { vs.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Price", () => { vs.SideSize = Size.Large; });
            Assert.PropertyChanged(vs, "Price", () => { vs.SideSize = Size.Medium; });
            Assert.PropertyChanged(vs, "Price", () => { vs.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            VokunSalad vs = new VokunSalad();
            Assert.PropertyChanged(vs, "Calories", () => { vs.SideSize = Size.Large; });
            Assert.PropertyChanged(vs, "Calories", () => { vs.SideSize = Size.Medium; });
            Assert.PropertyChanged(vs, "Calories", () => { vs.SideSize = Size.Small; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vs);
        }
    }
}