/*
 * Author: Zane Myers
 * Class name: OmeletteCustomization.cs
 * Purpose: Initializes OmeletteCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.MenuCategoryWindows.Customizations.EntreesCustomization
{
    /// <summary>
    /// Interaction logic for OmeletteCustomization.xaml
    /// </summary>
    public partial class OmeletteCustomization : UserControl
    {
        //new variable to modify and pass in
        public GardenOrcOmelette goo = new GardenOrcOmelette();

        /// <summary>
        /// initializes omelett customization
        /// </summary>
        public OmeletteCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the add to order button changes screen back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddOmeletteButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(goo);
            }
            order.Swap(menu);
        }

        /// <summary>
        /// event handler for the back button changes screen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OmelettesBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }
    }
}
