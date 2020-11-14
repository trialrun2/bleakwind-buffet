using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// list holding all menu items to be sorted into respective types
        /// </summary>
        public IEnumerable<IOrderItem> All { get; set; }

        /// <summary>
        /// list holding entrees to be displayed
        /// </summary>
        public IEnumerable<Entree> Entrees { get; set; }

        /// <summary>
        /// list holding sides to be displayed
        /// </summary>
        public IEnumerable<Side> Sides { get; set; }

        /// <summary>
        /// list holding drinks to be displayed
        /// </summary>
        public IEnumerable<Drink> Drinks { get; set; }

        /// <summary>
        /// list holding the different types
        /// </summary>
        public string[] Types { get; set; } 

        /// <summary>
        /// string holding the term to search for
        /// </summary>
        public string SearchTerms { get; set; }
         
        /// <summary>
        /// a nullable double holding the minimum price
        /// </summary>
        public double? Minprice { get; set; }

        /// <summary>
        /// a nullable double holding the maximum price
        /// </summary>
        public double? Maxprice { get; set; }

        /// <summary>
        /// a nullable int holding the minimum calories
        /// </summary>
        public int? Mincalories { get; set; }

        /// <summary>
        /// a nullable int holding the maximum calories
        /// </summary>
        public int? Maxcalories { get; set; }

        /// <summary>
        /// when submit is hit gets and filters the list of menu items to fit the search criteria
        /// </summary>
        /// <param name="MaxPrice">bound to max price</param>
        /// <param name="MinPrice">bound to min price</param>
        /// <param name="MinCalories">bound to min calories</param>
        /// <param name="MaxCalories">bound to max calories</param>
        public void OnGet(double? MaxPrice, double? MinPrice, int? MinCalories, int? MaxCalories)
        {
            All = Menu.FullMenu();
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            Maxprice = MaxPrice;
            Minprice = MinPrice;
            Mincalories = MinCalories;
            Maxcalories = MaxCalories;
            /*All = Menu.Search(All, SearchTerms);
            All = Menu.FilterByCategory(All, Types);
            All = Menu.FilterByCalories(All, MinCalories, MaxCalories);
            All = Menu.FilterByPrice(All, MinPrice, MaxPrice);*/
            //filter by search terms
            if (SearchTerms != null)
            {
                All = All.Where(item => item.Name != null && (item.Name.Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase) ||
                item.Description.Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase)));
            }

            //filter by Type
            if (Types != null && Types.Count() != 0)
            {
                if (Types.Contains("Entree") && Types.Contains("Drink") && Types.Contains("Side"))
                    All = All;
                else if (Types.Contains("Entree") && Types.Contains("Drink"))
                    All = All.Where(item => item is Entree || item is Drink);
                else if (Types.Contains("Entree") && Types.Contains("Side"))
                    All = All.Where(item => item is Entree || item is Side);
                else if (Types.Contains("Side") && Types.Contains("Drink"))
                    All = All.Where(item => item is Side || item is Drink);
                else if (Types.Contains("Entree"))
                    All = All.Where(item => item is Entree);
                else if (Types.Contains("Side"))
                    All = All.Where(item => item is Side);
                else if (Types.Contains("Drink"))
                    All = All.Where(item => item is Drink);
                else All = All;
            }

            //filter by Price
            if (MaxPrice != null && MinPrice == null)
            {
                All = All.Where(item => item.Price < MaxPrice);
            }
            if (MaxPrice == null && MinPrice != null)
            {
                All = All.Where(item => item.Price > MinPrice);
            }
            if (MaxPrice != null && MinPrice != null)
            {
                All = All.Where(item => item.Price > MinPrice && item.Price < MaxPrice);
            }

            //filter by Calories
            if (MaxCalories != null && MinCalories == null)
            {
                All = All.Where(item => item.Calories < MaxCalories);
            }
            if (MaxCalories == null && MinCalories != null)
            {
                All = All.Where(item => item.Calories > MinCalories);
            }
            if (MaxCalories != null && MinCalories != null)
            {
                All = All.Where(item => item.Calories < MaxCalories && item.Calories > MinCalories);
            }



            Entrees = Menu.GetEntrees(All);
            Sides = Menu.GetSides(All);
            Drinks = Menu.GetDrinks(All);
        }
    }
}
