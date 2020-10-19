/*
 * Author: Zane Myers
 * Class name: OrderTests.cs
 * Purpose: Test class for menu
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {

        [Fact]
        public void SalesTaxRateShouldBeTwelvePercentByDefault()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }

        [Fact]
        public void ShouldBeAbleToSetSalesTaxRate()
        {
            Order order = new Order();
            order.SalesTaxRate = .08;
            Assert.Equal(.08, order.SalesTaxRate);
            order.SalesTaxRate = .15;
            Assert.Equal(.15, order.SalesTaxRate);
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldHoldIOrderItems()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            order.Add(bb);
            order.Add(dwf);
            order.Add(aj);
            Assert.Contains<IOrderItem>(bb, order);
            Assert.Contains<IOrderItem>(dwf, order);
            Assert.Contains<IOrderItem>(aj, order);
        }
    }
}
