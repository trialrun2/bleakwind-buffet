﻿/*
 * Author: Zane Myers
 * Class name: MenuTests.cs
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

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {

        [Fact]
        public void EntreeListContainsAllEntrees() 
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr db = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsT_Bone ttb = new ThugsT_Bone();
            List<IOrderItem> entreeList = (List<IOrderItem>)Menu.Entrees();
            foreach(IOrderItem item in entreeList)
            {
                Assert.Contains(entreeList, item => item.ToString().Equals(bb.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(db.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(goo.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(pp.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(ss.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(tt.ToString()));
                Assert.Contains(entreeList, item => item.ToString().Equals(ttb.ToString()));
            }
        }

        [Fact]
        public void DrinkListContainsAllDrinks()
        {
            AretinoAppleJuice aj0 = new AretinoAppleJuice() { Size = Size.Small };
            AretinoAppleJuice aj1 = new AretinoAppleJuice() { Size = Size.Medium };
            AretinoAppleJuice aj2 = new AretinoAppleJuice() { Size = Size.Large };
            MarkarthMilk mm0 = new MarkarthMilk() { Size = Size.Small };
            MarkarthMilk mm1 = new MarkarthMilk() { Size = Size.Medium };
            MarkarthMilk mm2 = new MarkarthMilk() { Size = Size.Large };
            CandlehearthCoffee chc0 = new CandlehearthCoffee() { Size = Size.Small };
            CandlehearthCoffee chc1 = new CandlehearthCoffee() { Size = Size.Medium };
            CandlehearthCoffee chc2 = new CandlehearthCoffee() { Size = Size.Large };
            WarriorWater ww0 = new WarriorWater() { Size = Size.Small };
            WarriorWater ww1 = new WarriorWater() { Size = Size.Medium };
            WarriorWater ww2 = new WarriorWater() { Size = Size.Large };
            SailorSoda ss0 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Blackberry};
            SailorSoda ss1 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Blackberry };
            SailorSoda ss2 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Blackberry };
            SailorSoda ss3 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Cherry };
            SailorSoda ss4 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Cherry };
            SailorSoda ss5 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Cherry };
            SailorSoda ss6 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss7 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss8 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss9 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Lemon };
            SailorSoda ss10 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Lemon };
            SailorSoda ss11 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Lemon };
            SailorSoda ss12 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Peach };
            SailorSoda ss13 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Peach };
            SailorSoda ss14 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Peach };
            SailorSoda ss15 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Watermelon };
            SailorSoda ss16 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Watermelon };
            SailorSoda ss17 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Watermelon };

            List<IOrderItem> drinkList = (List<IOrderItem>)Menu.Drinks();
            foreach(IOrderItem item in drinkList)
            {
                Assert.Contains(drinkList, item => item.ToString().Equals(aj0.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(aj1.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(aj2.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(chc0.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(chc1.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(chc2.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(mm0.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(mm1.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(mm2.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ww0.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ww1.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ww2.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss0.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss1.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss2.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss3.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss4.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss5.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss6.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss7.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss8.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss9.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss10.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss11.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss12.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss13.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss14.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss15.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss16.ToString()));
                Assert.Contains(drinkList, item => item.ToString().Equals(ss17.ToString()));
            }

        }

        [Fact]
        public void SideListContainsAllSides()
        {
            DragonbornWaffleFries df0 = new DragonbornWaffleFries() { Size = Size.Small };
            DragonbornWaffleFries df1 = new DragonbornWaffleFries() { Size = Size.Medium };
            DragonbornWaffleFries df2 = new DragonbornWaffleFries() { Size = Size.Large };
            FriedMiraak fm0 = new FriedMiraak() { Size = Size.Small };
            FriedMiraak fm1 = new FriedMiraak() { Size = Size.Medium };
            FriedMiraak fm2 = new FriedMiraak() { Size = Size.Large };
            MadOtarGrits mog0 = new MadOtarGrits() { Size = Size.Small };
            MadOtarGrits mog1 = new MadOtarGrits() { Size = Size.Medium };
            MadOtarGrits mog2 = new MadOtarGrits() { Size = Size.Large };
            VokunSalad vs0 = new VokunSalad() { Size = Size.Small };
            VokunSalad vs1 = new VokunSalad() { Size = Size.Medium };
            VokunSalad vs2 = new VokunSalad() { Size = Size.Large };

            List<IOrderItem> sideList = (List<IOrderItem>)Menu.Sides();
            foreach (IOrderItem item in sideList)
            {
                Assert.Contains(sideList, item => item.ToString().Equals(df0.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(df1.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(df2.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(fm0.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(fm1.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(fm2.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(mog0.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(mog1.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(mog2.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(vs0.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(vs1.ToString()));
                Assert.Contains(sideList, item => item.ToString().Equals(vs2.ToString()));
            }
        }

        [Fact]
        public void MenuContainsAllMenuItems()
        {
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr db = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsT_Bone ttb = new ThugsT_Bone();

            AretinoAppleJuice aj0 = new AretinoAppleJuice() { Size = Size.Small };
            AretinoAppleJuice aj1 = new AretinoAppleJuice() { Size = Size.Medium };
            AretinoAppleJuice aj2 = new AretinoAppleJuice() { Size = Size.Large };
            MarkarthMilk mm0 = new MarkarthMilk() { Size = Size.Small };
            MarkarthMilk mm1 = new MarkarthMilk() { Size = Size.Medium };
            MarkarthMilk mm2 = new MarkarthMilk() { Size = Size.Large };
            CandlehearthCoffee chc0 = new CandlehearthCoffee() { Size = Size.Small };
            CandlehearthCoffee chc1 = new CandlehearthCoffee() { Size = Size.Medium };
            CandlehearthCoffee chc2 = new CandlehearthCoffee() { Size = Size.Large };
            WarriorWater ww0 = new WarriorWater() { Size = Size.Small };
            WarriorWater ww1 = new WarriorWater() { Size = Size.Medium };
            WarriorWater ww2 = new WarriorWater() { Size = Size.Large };
            SailorSoda ss0 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Blackberry };
            SailorSoda ss1 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Blackberry };
            SailorSoda ss2 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Blackberry };
            SailorSoda ss3 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Cherry };
            SailorSoda ss4 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Cherry };
            SailorSoda ss5 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Cherry };
            SailorSoda ss6 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss7 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss8 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Grapefruit };
            SailorSoda ss9 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Lemon };
            SailorSoda ss10 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Lemon };
            SailorSoda ss11 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Lemon };
            SailorSoda ss12 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Peach };
            SailorSoda ss13 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Peach };
            SailorSoda ss14 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Peach };
            SailorSoda ss15 = new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Watermelon };
            SailorSoda ss16 = new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Watermelon };
            SailorSoda ss17 = new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Watermelon };

            DragonbornWaffleFries df0 = new DragonbornWaffleFries() { Size = Size.Small };
            DragonbornWaffleFries df1 = new DragonbornWaffleFries() { Size = Size.Medium };
            DragonbornWaffleFries df2 = new DragonbornWaffleFries() { Size = Size.Large };
            FriedMiraak fm0 = new FriedMiraak() { Size = Size.Small };
            FriedMiraak fm1 = new FriedMiraak() { Size = Size.Medium };
            FriedMiraak fm2 = new FriedMiraak() { Size = Size.Large };
            MadOtarGrits mog0 = new MadOtarGrits() { Size = Size.Small };
            MadOtarGrits mog1 = new MadOtarGrits() { Size = Size.Medium };
            MadOtarGrits mog2 = new MadOtarGrits() { Size = Size.Large };
            VokunSalad vs0 = new VokunSalad() { Size = Size.Small };
            VokunSalad vs1 = new VokunSalad() { Size = Size.Medium };
            VokunSalad vs2 = new VokunSalad() { Size = Size.Large };

            List<IOrderItem> menu = (List<IOrderItem>)Menu.FullMenu();
     
            foreach (IOrderItem item in menu)
            {
                Assert.Contains(menu, item => item.ToString().Equals(bb.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(db.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(goo.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(pp.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(tt.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ttb.ToString()));

                Assert.Contains(menu, item => item.ToString().Equals(aj0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(aj1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(aj2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(chc0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(chc1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(chc2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mm0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mm1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mm2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ww0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ww1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ww2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss3.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss4.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss5.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss6.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss7.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss8.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss9.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss10.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss11.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss12.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss13.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss14.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss15.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss16.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(ss17.ToString()));

                Assert.Contains(menu, item => item.ToString().Equals(df0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(df1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(df2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(fm0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(fm1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(fm2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mog0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mog1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(mog2.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(vs0.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(vs1.ToString()));
                Assert.Contains(menu, item => item.ToString().Equals(vs2.ToString()));
            }
        }
    }
}
