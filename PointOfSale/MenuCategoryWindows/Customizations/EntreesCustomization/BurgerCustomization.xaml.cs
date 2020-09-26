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
        public BurgerCustomization()
        {
            InitializeComponent();
        }
        
        void AddBurgerButton(object sender, RoutedEventArgs e)
        {

        }

        void BurgersBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entrees = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entrees);
        }

        public void EnableDisableBurger(int enableDisable)
        {
            if (enableDisable == 0)
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
            else if(enableDisable == 1)
            {
                baconCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
                baconCheck.IsChecked = false;
                eggCheck.IsChecked = false;
            }
            else
            {

            }
        }
    }
}
