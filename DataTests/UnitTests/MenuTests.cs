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
            AretinoAppleJuice aj0 = new AretinoAppleJuice() { CupSize = Size.Small };
            AretinoAppleJuice aj1 = new AretinoAppleJuice() { CupSize = Size.Medium };
            AretinoAppleJuice aj2 = new AretinoAppleJuice() { CupSize = Size.Large };
            MarkarthMilk mm0 = new MarkarthMilk() { CupSize = Size.Small };
            MarkarthMilk mm1 = new MarkarthMilk() { CupSize = Size.Medium };
            MarkarthMilk mm2 = new MarkarthMilk() { CupSize = Size.Large };
            CandlehearthCoffee chc0 = new CandlehearthCoffee() { CupSize = Size.Small };
            CandlehearthCoffee chc1 = new CandlehearthCoffee() { CupSize = Size.Medium };
            CandlehearthCoffee chc2 = new CandlehearthCoffee() { CupSize = Size.Large };
            WarriorWater ww0 = new WarriorWater() { CupSize = Size.Small };
            WarriorWater ww1 = new WarriorWater() { CupSize = Size.Medium };
            WarriorWater ww2 = new WarriorWater() { CupSize = Size.Large };
            SailorSoda ss0 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Blackberry};
            SailorSoda ss1 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Blackberry };
            SailorSoda ss2 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Blackberry };
            SailorSoda ss3 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Cherry };
            SailorSoda ss4 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Cherry };
            SailorSoda ss5 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Cherry };
            SailorSoda ss6 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss7 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss8 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss9 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Lemon };
            SailorSoda ss10 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Lemon };
            SailorSoda ss11 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Lemon };
            SailorSoda ss12 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Peach };
            SailorSoda ss13 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Peach };
            SailorSoda ss14 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Peach };
            SailorSoda ss15 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Watermelon };
            SailorSoda ss16 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Watermelon };
            SailorSoda ss17 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Watermelon };

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
            DragonbornWaffleFries df0 = new DragonbornWaffleFries() { SideSize = Size.Small };
            DragonbornWaffleFries df1 = new DragonbornWaffleFries() { SideSize = Size.Medium };
            DragonbornWaffleFries df2 = new DragonbornWaffleFries() { SideSize = Size.Large };
            FriedMiraak fm0 = new FriedMiraak() { SideSize = Size.Small };
            FriedMiraak fm1 = new FriedMiraak() { SideSize = Size.Medium };
            FriedMiraak fm2 = new FriedMiraak() { SideSize = Size.Large };
            MadOtarGrits mog0 = new MadOtarGrits() { SideSize = Size.Small };
            MadOtarGrits mog1 = new MadOtarGrits() { SideSize = Size.Medium };
            MadOtarGrits mog2 = new MadOtarGrits() { SideSize = Size.Large };
            VokunSalad vs0 = new VokunSalad() { SideSize = Size.Small };
            VokunSalad vs1 = new VokunSalad() { SideSize = Size.Medium };
            VokunSalad vs2 = new VokunSalad() { SideSize = Size.Large };

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

            AretinoAppleJuice aj0 = new AretinoAppleJuice() { CupSize = Size.Small };
            AretinoAppleJuice aj1 = new AretinoAppleJuice() { CupSize = Size.Medium };
            AretinoAppleJuice aj2 = new AretinoAppleJuice() { CupSize = Size.Large };
            MarkarthMilk mm0 = new MarkarthMilk() { CupSize = Size.Small };
            MarkarthMilk mm1 = new MarkarthMilk() { CupSize = Size.Medium };
            MarkarthMilk mm2 = new MarkarthMilk() { CupSize = Size.Large };
            CandlehearthCoffee chc0 = new CandlehearthCoffee() { CupSize = Size.Small };
            CandlehearthCoffee chc1 = new CandlehearthCoffee() { CupSize = Size.Medium };
            CandlehearthCoffee chc2 = new CandlehearthCoffee() { CupSize = Size.Large };
            WarriorWater ww0 = new WarriorWater() { CupSize = Size.Small };
            WarriorWater ww1 = new WarriorWater() { CupSize = Size.Medium };
            WarriorWater ww2 = new WarriorWater() { CupSize = Size.Large };
            SailorSoda ss0 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Blackberry };
            SailorSoda ss1 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Blackberry };
            SailorSoda ss2 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Blackberry };
            SailorSoda ss3 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Cherry };
            SailorSoda ss4 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Cherry };
            SailorSoda ss5 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Cherry };
            SailorSoda ss6 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss7 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss8 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Grapefruit };
            SailorSoda ss9 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Lemon };
            SailorSoda ss10 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Lemon };
            SailorSoda ss11 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Lemon };
            SailorSoda ss12 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Peach };
            SailorSoda ss13 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Peach };
            SailorSoda ss14 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Peach };
            SailorSoda ss15 = new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Watermelon };
            SailorSoda ss16 = new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Watermelon };
            SailorSoda ss17 = new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Watermelon };

            DragonbornWaffleFries df0 = new DragonbornWaffleFries() { SideSize = Size.Small };
            DragonbornWaffleFries df1 = new DragonbornWaffleFries() { SideSize = Size.Medium };
            DragonbornWaffleFries df2 = new DragonbornWaffleFries() { SideSize = Size.Large };
            FriedMiraak fm0 = new FriedMiraak() { SideSize = Size.Small };
            FriedMiraak fm1 = new FriedMiraak() { SideSize = Size.Medium };
            FriedMiraak fm2 = new FriedMiraak() { SideSize = Size.Large };
            MadOtarGrits mog0 = new MadOtarGrits() { SideSize = Size.Small };
            MadOtarGrits mog1 = new MadOtarGrits() { SideSize = Size.Medium };
            MadOtarGrits mog2 = new MadOtarGrits() { SideSize = Size.Large };
            VokunSalad vs0 = new VokunSalad() { SideSize = Size.Small };
            VokunSalad vs1 = new VokunSalad() { SideSize = Size.Medium };
            VokunSalad vs2 = new VokunSalad() { SideSize = Size.Large };

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
