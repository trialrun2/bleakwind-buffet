/*
 * Author: Zane Myers
 * Class name: FlavorCustomization.cs
 * Purpose: Initializes FlavorCustomization and handles events for the menu
 */

using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization
{
    /// <summary>
    /// Interaction logic for FlavorCustomization.xaml
    /// </summary>
    public partial class FlavorCustomization : UserControl
    {
        //variable to hold soda passedIn and pass it on
        SailorSoda ss = new SailorSoda();

        /// <summary>
        /// initializes flavor customization and disables next button
        /// </summary>
        public FlavorCustomization(SailorSoda passedIn)
        {
            InitializeComponent();
            DataContext = passedIn;
            ss = passedIn;
        }

        /// <summary>
        /// event handler for the next button lets size customization know where to return to
        /// and changes screen to size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorNextButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization size = new SizeCustomization(0, ss);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(size);
        }

        /// <summary>
        /// event handler for the back button changes screen back to drink special requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorBackButton(object sender, RoutedEventArgs e)
        {
            DrinkCustomizations src = new DrinkCustomizations(ss, 0);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }
    }
}
