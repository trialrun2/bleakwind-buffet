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
using System.Diagnostics;

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

        /// <summary>
        /// searches the list of menu items for matches
        /// </summary>
        /// <param name="menu">list of all items</param>
        /// <param name="search">there term to search for</param>
        /// <returns>results of the search</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string terms)
        {
            List<IOrderItem> result = new List<IOrderItem>();

            //null check
            if(terms == null)
            {
                return menu;
            }

            foreach(IOrderItem item in menu)
            {
                // add the menu item if the name contains the search term
                if (item.Name != null)
                {
                    string name = item.Name.ToLower();
                    terms = terms.ToLower();
                    if (name.Contains(terms))
                    {
                        result.Add(item);
                    }
                }   
            }
            return result;
        }

        /// <summary>
        /// Gets the possible food types
        /// </summary>
        public static string[] Types
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }

        /// <summary>
        /// filters the menu items by category
        /// </summary>
        /// <param name="menu">the list of menu items to search through</param>
        /// <param name="type">the type of item/s we want</param>
        /// <returns>result of the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> type)
        {
            if (type == null || type.Count() == 0) return menu;

            //Filter the supplied collection of menu items
            List<IOrderItem> result = new List<IOrderItem>();
            if (type.Contains("Entree"))
            {
                foreach(IOrderItem item in menu)
                {
                    if (item is Entree)
                    {
                        result.Add(item);
                    }
                }
            }
            if (type.Contains("Side"))
            {
                foreach (IOrderItem item in menu)
                {
                    if (item is Side)
                    {
                        result.Add(item);
                    }
                }
            }
            if (type.Contains("Drink"))
            {
                foreach (IOrderItem item in menu)
                {
                    if (item is Drink)
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// filters the menu items by calories
        /// </summary>
        /// <param name="menu">the list of menu items to filter</param>
        /// <param name="min">the minimum amount of calories</param>
        /// <param name="max">the maximum amount of calories</param>
        /// <returns>returns the result of the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
        {
            //null check
            if (min == null && max == null) return menu;

            var result = new List<IOrderItem>();

            //only a max specified
            if(min == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Calories <= max) result.Add(item);
                }
                return result;
            }

            //only a min specified
            if(max == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Calories >= min) result.Add(item);
                }
                return result;
            }

            //both min and max specified
            foreach(IOrderItem item in menu)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    result.Add(item);
                }
            }

            return result;
        }
        
        /// <summary>
        /// Filters the menu items by price
        /// </summary>
        /// <param name="menu">the list of menu items to be filtered</param>
        /// <param name="min">the minimum price</param>
        /// <param name="max">the maximum price</param>
        /// <returns>the result of the filter</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            //null check
            if (min == null && max == null) return menu;

            var result = new List<IOrderItem>();

            //only a max specified
            if(min == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Price <= max) result.Add(item);
                }
                return result;
            }

            // only a min specified
            if(max == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Price >= max) result.Add(item);
                }
                return result;
            }

            // both min and max specified
            foreach(IOrderItem item in menu)
            {
                if(item.Price >= min && item.Price <= max)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// gets the entrees from the menu items
        /// </summary>
        /// <param name="menu">the list of items left</param>
        /// <returns>the result of the filter</returns>
        public static IEnumerable<Entree> GetEntrees (IEnumerable<IOrderItem> menu)
        {
            List<Entree> entrees = new List<Entree>();

            foreach(IOrderItem item in menu)
            {
                if(item is Entree entree)
                {
                    entrees.Add(entree);
                }
            }

            return entrees;
        }

        /// <summary>
        /// gets the sides from the menu items
        /// </summary>
        /// <param name="menu">the list of items left</param>
        /// <returns>the result of the filter</returns>
        public static IEnumerable<Side> GetSides (IEnumerable<IOrderItem> menu)
        {
            List<Side> sides = new List<Side>();

            foreach (IOrderItem item in menu)
            {
                if (item is Side side)
                {
                    sides.Add(side);
                }
            }

            return sides;
        }

        /// <summary>
        /// gets the drinks from the menu itemes
        /// </summary>
        /// <param name="menu">the list of items left</param>
        /// <returns>the result of the filter</returns>
        public static IEnumerable<Drink> GetDrinks (IEnumerable<IOrderItem> menu)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (IOrderItem item in menu)
            {
                if (item is Drink drink)
                {
                    drinks.Add(drink);
                }
            }

            return drinks;
        }
    }
}
