﻿/*
 * Author: Zachery Brunner, and Zane Myers
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */

using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.IsAssignableFrom<IOrderItem>(ttb);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.IsAssignableFrom<Entree>(ttb);
        }

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
            Assert.Empty(ttb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }
    }
}