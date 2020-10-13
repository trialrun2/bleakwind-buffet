/*
 * Author: Zane Myers
 * Class name: DrinkCustomization.cs
 * Purpose: Initializes DrinkCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

namespace PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization
{
    /// <summary>
    /// Interaction logic for SpecialRequestCustomizations.xaml
    /// </summary>
    public partial class DrinkCustomizations : UserControl
    {
        //private int variable used to determine where to go next
        private int drinkType;
        IOrderItem passIn = null;
        public SailorSoda ss = new SailorSoda();
        public CandlehearthCoffee chc = new CandlehearthCoffee();
        public WarriorWater ww = new WarriorWater();
        public MarkarthMilk mm = new MarkarthMilk();
        public AretinoAppleJuice aj = new AretinoAppleJuice();

        /// <summary>
        /// initializes drink special requests
        /// </summary>
        public DrinkCustomizations(IOrderItem drink, int dType)
        {
            InitializeComponent();
            DataContext = drink;
            drinkType = dType;
            EnableDisableDrink();
            if (drinkType == 0) ss = (SailorSoda)drink;
            else if (drinkType == 1) chc = (CandlehearthCoffee)drink;
            else if (drinkType == 2) ww = (WarriorWater)drink;
            else if (drinkType == 3) aj = (AretinoAppleJuice)drink;
            else mm = (MarkarthMilk)drink;

        }

        /// <summary>
        /// event hadler for next button, changes to either flavor customization, or size customization based
        /// on the soda variables value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomDrinkNextButton(object sender, RoutedEventArgs e)
        {
            
            if(drinkType == 0)//if it is a Sailor Soda
            {
                FlavorCustomization flavor = new FlavorCustomization(ss);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(flavor);
            }
            else//if its not a soda
            {
                if(drinkType == 1) { passIn = chc; }
                else if(drinkType == 2) { passIn = ww; }
                else if(drinkType == 3) { passIn = aj; }
                else { passIn = mm; }
                SizeCustomization size = new SizeCustomization(drinkType, passIn);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(size);
            }
        }

        /// <summary>
        /// event handler for the back button changes screen back to drink menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="es"></param>
        void CustomDrinkBackButton(object sender, RoutedEventArgs es)
        {
            DrinksMenu drink = new DrinksMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(drink);
        }

        /// <summary>
        /// called when special requests is initialized to determine what to disable
        /// </summary>
        /// <param name="enableDisable"></param>
        public void EnableDisableDrink()
        {
            if (drinkType == 0)//if it's soda
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
                iceCheck.IsEnabled = true;
                lemonCheck.IsChecked = false;
                decafCheck.IsChecked = false;
                creamCheck.IsChecked = false;
                iceCheck.IsChecked = true;
            }
            else if (drinkType == 1)// if it's coffee
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = true;
                creamCheck.IsEnabled = true;
                iceCheck.IsEnabled = true;
                lemonCheck.IsChecked = false;
                decafCheck.IsChecked = false;
                creamCheck.IsChecked = false;
                iceCheck.IsChecked = false;
            }
            else if (drinkType == 2)// if its water
            {
                lemonCheck.IsEnabled = true;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
                iceCheck.IsEnabled = true;
                lemonCheck.IsChecked = false;
                decafCheck.IsChecked = false;
                creamCheck.IsChecked = false;
                iceCheck.IsChecked = true;
            }
            else if (drinkType == 3)// if it's apple juice
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
                iceCheck.IsEnabled = true;
                lemonCheck.IsChecked = false;
                decafCheck.IsChecked = false;
                creamCheck.IsChecked = false;
                iceCheck.IsChecked = false;
            }
            else// if it's milk
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
                iceCheck.IsEnabled = true;
                lemonCheck.IsChecked = false;
                decafCheck.IsChecked = false;
                creamCheck.IsChecked = false;
                iceCheck.IsChecked = false;
            }
        }
    }
}
