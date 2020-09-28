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
        private int sideOrDrink;

        /// <summary>
        /// initializes size customization
        /// </summary>
        public SizeCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeOfSide(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// event handler for the back button chooses to change the screen to sides menu, drinks customizion, or flavor
        /// customization based on the private variable sideOrd drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeBackButton(object sender, RoutedEventArgs e)
        {
            object swap = null;
            if(sideOrDrink == 0)// if it's a side
            {
                swap = new SidesMenu();
            }
            if(sideOrDrink == 1)// if its a drink other than a soda
            {
                swap = new DrinkCustomizations();
            }
            if(sideOrDrink == 2)// if its a drink and a soda
            {
                swap = new FlavorCustomization();
            }
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(swap);
        }

        /// <summary>
        /// event handler for the add to order button returns to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

        /// <summary>
        /// called when size customization is initialized to set sideOrDrink variable
        /// </summary>
        /// <param name="isSideOrDrink"></param>
        public void SideOrDrink(int isSideOrDrink)
        {
            sideOrDrink = isSideOrDrink;
        }
    }
}
