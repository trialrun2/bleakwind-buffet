using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class for lists of the menu items
    /// </summary>
    public static class Menu
    {

        /// <summary>
        /// Creates a list of all entree items
        /// </summary>
        /// <returns>
        /// A list of all entree items
        /// </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();
            entreeList.Add(new BriarheartBurger());
            entreeList.Add(new DoubleDraugr());
            entreeList.Add(new GardenOrcOmelette());
            entreeList.Add(new PhillyPoacher());
            entreeList.Add(new SmokehouseSkeleton());
            entreeList.Add(new ThalmorTriple());
            entreeList.Add(new ThugsT_Bone());
            return entreeList;
        }

        /// <summary>
        /// Creates a list of all drink items
        /// </summary>
        /// <returns>
        /// a list of all drink items
        /// </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Blackberry});
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Blackberry });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Blackberry });
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Cherry });
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Watermelon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Watermelon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Watermelon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Peach });
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Lemon });
            drinkList.Add(new SailorSoda() { CupSize = Size.Small, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new SailorSoda() { CupSize = Size.Medium, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new SailorSoda() { CupSize = Size.Large, Flavor = SodaFlavor.Grapefruit });
            drinkList.Add(new AretinoAppleJuice() { CupSize = Size.Small });
            drinkList.Add(new AretinoAppleJuice() { CupSize = Size.Medium });
            drinkList.Add(new AretinoAppleJuice() { CupSize = Size.Large });
            drinkList.Add(new MarkarthMilk() { CupSize = Size.Small });
            drinkList.Add(new MarkarthMilk() { CupSize = Size.Medium });
            drinkList.Add(new MarkarthMilk() { CupSize = Size.Large });
            drinkList.Add(new WarriorWater() { CupSize = Size.Small });
            drinkList.Add(new WarriorWater() { CupSize = Size.Medium });
            drinkList.Add(new WarriorWater() { CupSize = Size.Large });
            drinkList.Add(new CandlehearthCoffee() { CupSize = Size.Small });
            drinkList.Add(new CandlehearthCoffee() { CupSize = Size.Medium });
            drinkList.Add(new CandlehearthCoffee() { CupSize = Size.Large });

            return drinkList;
        }

        /// <summary>
        /// Creates a list of all sides
        /// </summary>
        /// <returns>
        /// A list of all side items
        /// </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();
            sideList.Add(new DragonbornWaffleFries() { SideSize = Size.Small });
            sideList.Add(new DragonbornWaffleFries() { SideSize = Size.Medium });
            sideList.Add(new DragonbornWaffleFries() { SideSize = Size.Large });
            sideList.Add(new FriedMiraak() { SideSize = Size.Small });
            sideList.Add(new FriedMiraak() { SideSize = Size.Medium });
            sideList.Add(new FriedMiraak() { SideSize = Size.Large });
            sideList.Add(new MadOtarGrits() { SideSize = Size.Small });
            sideList.Add(new MadOtarGrits() { SideSize = Size.Medium });
            sideList.Add(new MadOtarGrits() { SideSize = Size.Large });
            sideList.Add(new VokunSalad() { SideSize = Size.Small });
            sideList.Add(new VokunSalad() { SideSize = Size.Medium });
            sideList.Add(new VokunSalad() { SideSize = Size.Large });
            return sideList;
        } 

        /// <summary>
        /// Creates a list of all menu items
        /// </summary>
        /// <returns>
        /// a list of all menu items
        /// </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenuList = new List<IOrderItem>();
            List<IOrderItem> entreeItems = (List<IOrderItem>)Entrees();
            List<IOrderItem> drinkItems = (List<IOrderItem>)Drinks();
            List<IOrderItem> sideItems = (List<IOrderItem>)Sides();
            fullMenuList.AddRange(entreeItems);
            fullMenuList.AddRange(drinkItems);
            fullMenuList.AddRange(sideItems);
            return fullMenuList;
        }
    }
}
