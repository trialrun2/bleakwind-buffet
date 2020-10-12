/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(404, (double)goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;

            if (!includeBroccoli)
            {
                Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            }
            if (!includeMushrooms)
            {
                Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", goo.SpecialInstructions);
            }
            if (!includeCheddar)
            {
                Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            }
            if(includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
            {
                Assert.Empty(goo.SpecialInstructions);
            }

        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Broccoli", () => { goo.Broccoli = false; });
            Assert.PropertyChanged(goo, "Broccoli", () => { goo.Broccoli = true; });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Mushrooms", () => { goo.Mushrooms = false; });
            Assert.PropertyChanged(goo, "Mushrooms", () => { goo.Mushrooms = true; });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Tomato", () => { goo.Tomato = false; });
            Assert.PropertyChanged(goo, "Tomato", () => { goo.Tomato = true; });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "Cheddar", () => { goo.Cheddar = false; });
            Assert.PropertyChanged(goo, "Cheddar", () => { goo.Cheddar = true; });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Cheddar = false; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Cheddar = true; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Tomato = false; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Tomato = true; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Mushrooms = false; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Mushrooms = true; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Broccoli = false; });
            Assert.PropertyChanged(goo, "SpecialInstructions", () => { goo.Broccoli = true; });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }
    }
}