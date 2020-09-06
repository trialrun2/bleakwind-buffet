/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.Equal(6.44, ttb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.Equal(982, (double)ttb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.Empty(ttb.SpecialInstuctions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}