/*
 * Author: Zane Myers
 * Class name: SizeCustomization.cs
 * Purpose: Initializes SizeCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.MenuCategoryWindows.Customizations
{
    /// <summary>
    /// Interaction logic for SizeCustomization.xaml
    /// </summary>
    public partial class SizeCustomization : UserControl
    {
        //private int variable to allow size to know where to return if back is pressed
        private int sideOrDrinkType;

        // object variables to hold the incoming object;
        public IOrderItem obj;

        /// <summary>
        /// initializes size customization disables the add item button
        /// </summary>
        public SizeCustomization(int isSideOrDrink, IOrderItem item)
        {
            InitializeComponent();
            DataContext = item;
            obj = item;
            sideOrDrinkType = isSideOrDrink;  
        }

        /// <summary>
        /// event handler for the back button chooses to change the screen to sides menu, drinks customizion, or flavor
        /// customization based on the private variable sideOrd drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeBackButton(object sender, RoutedEventArgs e)
        {
            if(sideOrDrinkType == 5 || sideOrDrinkType == 6 || sideOrDrinkType == 7 || sideOrDrinkType == 8)// if it's a side
            {
                SidesMenu swap = new SidesMenu();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(swap);
            }
            else if(sideOrDrinkType == 0)// if its a drink and a soda
            {
                FlavorCustomization swap = new FlavorCustomization((SailorSoda) obj);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(swap);
            }
            else // if its any other drink type
            {
                DrinkCustomizations swap = new DrinkCustomizations(obj, sideOrDrinkType);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(swap);
            }
            
        }

        /// <summary>
        /// event handler for the add to order button returns to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemDoneButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);         
        }
    }
}
