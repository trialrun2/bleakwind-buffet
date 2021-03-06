﻿/*
 * Author: Zane Myers
 * Class name: BurgerCustomization.cs
 * Purpose: Initializes BurgerCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.MenuCategoryWindows.Customizations.EntreesCustomization
{
    /// <summary>
    /// Interaction logic for BurgerCustomization.xaml
    /// </summary>
    public partial class BurgerCustomization : UserControl
    {
        private int burgerType;

        /// <summary>
        /// initializes burger customization
        /// </summary>
        public BurgerCustomization(IOrderItem burger, int burgType)
        {
            InitializeComponent();       
            burgerType = burgType;
            DataContext = burger;
            EnableDisableBurger();
        }

        /// <summary>
        /// event handler for the add to order button changes screen back to main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton(object sender, RoutedEventArgs e)
        {
            OrderWindow order = this.FindAncestor<OrderWindow>();
            MenuWindow menu = new MenuWindow();
            order.Swap(menu);
            
        }

        /// <summary>
        /// event handler for the back button changes sreen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BurgersBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entrees = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entrees);
        }

        /// <summary>
        /// called when burger customization is initialized to determine what type of burger we want, enables or disables, checks or unchecks the proper 
        /// boxes for the assigned burger
        /// </summary>
        /// <param name="enableDisable"></param>
        private void EnableDisableBurger()
        {
            if (burgerType == 0)//if it's a briarheart burger
            {
                tomatoCheck.IsEnabled = false;
                baconCheck.IsEnabled = false;
                mayoCheck.IsEnabled = false;
                lettuceCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
            }
            else if(burgerType == 1)// if it's a double draugr
            {
                baconCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
            }
            else // if its a thalmor triple
            {
            }
        }
    }
}
