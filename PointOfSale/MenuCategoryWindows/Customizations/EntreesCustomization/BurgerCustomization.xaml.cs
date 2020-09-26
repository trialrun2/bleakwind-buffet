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
    /// Interaction logic for BurgerCustomization.xaml
    /// </summary>
    public partial class BurgerCustomization : UserControl
    {
        /// <summary>
        /// initializes burger customization
        /// </summary>
        public BurgerCustomization()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// event handler for the add to order button changes screen back to main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddBurgerButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
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
        /// called when burger customization is initialized to determine what type of burger we want
        /// </summary>
        /// <param name="enableDisable"></param>
        public void EnableDisableBurger(int enableDisable)
        {
            if (enableDisable == 0)//if it's a briarheart burger
            {
                tomatoCheck.IsEnabled = false;
                baconCheck.IsEnabled = false;
                mayoCheck.IsEnabled = false;
                lettuceCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
                tomatoCheck.IsChecked = false;
                baconCheck.IsChecked = false;
                mayoCheck.IsChecked = false;
                lettuceCheck.IsChecked = false;
                eggCheck.IsChecked = false;
            }
            else if(enableDisable == 1)// if it's a double draugr
            {
                baconCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
                baconCheck.IsChecked = false;
                eggCheck.IsChecked = false;
            }
            else // if its a thalmor triple
            {

            }
        }
    }
}
