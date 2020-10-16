/*
 * Author: Zane Myers
 * Class name: Menu.cs
 * Purpose: Class creates Lists of IOrderItem holding just entrees, just drinks, just sides, and one holding all items
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.ComponentModel;

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
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Blackberry});
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Blackberry });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Blackberry });
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Cherry });
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Watermelon });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Watermelon });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Watermelon });
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Peach });
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Lemon });
            drinkList.Add(new SailorSoda() { Size = Size.Small, SodaFlavor = Flavor.Grapefruit });
            drinkList.Add(new SailorSoda() { Size = Size.Medium, SodaFlavor = Flavor.Grapefruit });
            drinkList.Add(new SailorSoda() { Size = Size.Large, SodaFlavor = Flavor.Grapefruit });
            drinkList.Add(new AretinoAppleJuice() { Size = Size.Small });
            drinkList.Add(new AretinoAppleJuice() { Size = Size.Medium });
            drinkList.Add(new AretinoAppleJuice() { Size = Size.Large });
            drinkList.Add(new MarkarthMilk() { Size = Size.Small });
            drinkList.Add(new MarkarthMilk() { Size = Size.Medium });
            drinkList.Add(new MarkarthMilk() { Size = Size.Large });
            drinkList.Add(new WarriorWater() { Size = Size.Small });
            drinkList.Add(new WarriorWater() { Size = Size.Medium });
            drinkList.Add(new WarriorWater() { Size = Size.Large });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Small });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Medium });
            drinkList.Add(new CandlehearthCoffee() { Size = Size.Large });

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
            sideList.Add(new DragonbornWaffleFries() { Size = Size.Small });
            sideList.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            sideList.Add(new DragonbornWaffleFries() { Size = Size.Large });
            sideList.Add(new FriedMiraak() { Size = Size.Small });
            sideList.Add(new FriedMiraak() { Size = Size.Medium });
            sideList.Add(new FriedMiraak() { Size = Size.Large });
            sideList.Add(new MadOtarGrits() { Size = Size.Small });
            sideList.Add(new MadOtarGrits() { Size = Size.Medium });
            sideList.Add(new MadOtarGrits() { Size = Size.Large });
            sideList.Add(new VokunSalad() { Size = Size.Small });
            sideList.Add(new VokunSalad() { Size = Size.Medium });
            sideList.Add(new VokunSalad() { Size = Size.Large });
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
