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
            DrinkCustomizations src = new DrinkCustomizations();
            src.EnableDisableDrink(3);
            OrderWindow order = this.FindAncestor<OrderWindow>();
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
            DrinkCustomizations src = new DrinkCustomizations();
            src.EnableDisableDrink(1);
            OrderWindow order = this.FindAncestor<OrderWindow>();
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
            DrinkCustomizations src = new DrinkCustomizations();
            src.EnableDisableDrink(4);
            OrderWindow order = this.FindAncestor<OrderWindow>();
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
            DrinkCustomizations src = new DrinkCustomizations();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            src.EnableDisableDrink(0);
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
            DrinkCustomizations src = new DrinkCustomizations();
            src.EnableDisableDrink(2);
            OrderWindow order = this.FindAncestor<OrderWindow>();
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
