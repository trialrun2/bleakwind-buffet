/*
 * Author: Zane Myers
 * Class name: DrinksMenu.cs
 * Purpose: Initializes DrinksMenu and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.MenuCategoryWindows
{
    /// <summary>
    /// Interaction logic for DrinksMenu.xaml
    /// </summary>
    public partial class DrinksMenu : UserControl
    {
        /// <summary>
        /// initializes the drink menu
        /// </summary>
        public DrinksMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the apple juice button tells drink customization what to disable
        /// changes screen to special requests customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AppleJuiceButton(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            DrinkCustomizations src = new DrinkCustomizations(aj, 3);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(aj);
            }
            order.Swap(src);
        }

        /// <summary>
        /// event handler for the coffee button tells drink customization what to disable
        /// changes screen to special requests customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CoffeeButton(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            DrinkCustomizations src = new DrinkCustomizations(chc, 1);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(chc);
            }
            order.Swap(src);
        }

        /// <summary>
        /// event handler for the milk button tells drink customization what to disable
        /// changes screen to special requests customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MilkButton(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            DrinkCustomizations src = new DrinkCustomizations(mm, 4);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(mm);
            }
            order.Swap(src);
        }

        /// <summary>
        /// event handler for the soda button tells drink customization what to disable
        /// changes screen to special requests customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SodaButton(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            DrinkCustomizations src = new DrinkCustomizations(ss, 0);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(ss);
            }
            order.Swap(src);
        }

        /// <summary>
        /// event handler for the water button tells drink customization what to disable
        /// changes screen to special requests customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WaterButton(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            DrinkCustomizations src = new DrinkCustomizations(ww, 2);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(ww);
            }
            order.Swap(src);
        }

        /// <summary>
        /// event handler for the back button changes screen back to main menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DrinksBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }
    }
}
