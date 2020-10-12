/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mog);
        }

        [Fact]
        public void ShouldBeAnSide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.SideSize);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.SideSize = Size.Large;
            Assert.Equal(Size.Large, mog.SideSize);
            mog.SideSize = Size.Medium;
            Assert.Equal(Size.Medium, mog.SideSize);
            mog.SideSize = Size.Small;
            Assert.Equal(Size.Small, mog.SideSize);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.SideSize = size;
            Assert.Equal(price, mog.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.SideSize = size;
            Assert.Equal(calories, mog.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.SideSize = size;
            Assert.Equal(name, mog.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.PropertyChanged(mog, "Size", () => { mog.SideSize = Size.Large; });
            Assert.PropertyChanged(mog, "Size", () => { mog.SideSize = Size.Medium; });
            Assert.PropertyChanged(mog, "Size", () => { mog.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.PropertyChanged(mog, "Price", () => { mog.SideSize = Size.Large; });
            Assert.PropertyChanged(mog, "Price", () => { mog.SideSize = Size.Medium; });
            Assert.PropertyChanged(mog, "Price", () => { mog.SideSize = Size.Small; });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.PropertyChanged(mog, "Calories", () => { mog.SideSize = Size.Large; });
            Assert.PropertyChanged(mog, "Calories", () => { mog.SideSize = Size.Medium; });
            Assert.PropertyChanged(mog, "Calories", () => { mog.SideSize = Size.Small; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mog);
        }
    }
}