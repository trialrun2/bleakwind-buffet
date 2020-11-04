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
        public IEnumerable<IOrderItem> All { get; set; }

        public IEnumerable<Entree> Entrees { get; set; }

        public IEnumerable<Side> Sides { get; set; }

        public IEnumerable<Drink> Drinks { get; set; }

        public string[] Types { get; set; } 

        public string SearchTerms { get; set; }

        public double? Minprice { get; set; }

        public double? Maxprice { get; set; }

        public int? Mincaloreis { get; set; }

        public int? Maxcalories { get; set; }

        public void OnGet(double? MaxPrice, double? MinPrice, int? MinCalories, int? MaxCalories)
        {
            All = Menu.FullMenu();
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            Maxprice = MaxPrice;
            Minprice = MinPrice;
            Mincaloreis = MinCalories;
            Maxcalories = MaxCalories;
            All = Menu.Search(All, SearchTerms);
            All = Menu.FilterByCategory(All, Types);
            All = Menu.FilterByCalories(All, MinCalories, MaxCalories);
            All = Menu.FilterByPrice(All, MinPrice, MaxPrice);
            Entrees = Menu.GetEntrees(All);
            Sides = Menu.GetSides(All);
            Drinks = Menu.GetDrinks(All);
        }
    }
}
