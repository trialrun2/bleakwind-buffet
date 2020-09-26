using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
using PointOfSale.MenuCategoryWindows;
using PointOfSale.MenuCategoryWindows.Customizations;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : UserControl
    {
        /// <summary>
        /// Initializes the menu window
        /// </summary>
        public MenuWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the drink button swaps screen to drink menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DrinkButton(object sender, RoutedEventArgs e)
        {
            DrinksMenu drinks = new DrinksMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(drinks);
        }

        /// <summary>
        /// event handler for the entree button swaps screen to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EntreeButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }

        /// <summary>
        /// event handler for side button swaps screen to sides menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SideButton(object sender, RoutedEventArgs e)
        {
            SidesMenu side = new SidesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(side);
        }
    }
}
