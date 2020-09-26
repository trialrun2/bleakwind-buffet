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
    /// Interaction logic for SpecialRequestCustomizations.xaml
    /// </summary>
    public partial class SpecialRequestCustomizations : UserControl
    {
        private int soda = 0;
        public SpecialRequestCustomizations()
        {
            InitializeComponent();
        }

        void RequestsNextButton(object sender, RoutedEventArgs e)
        {
            
            if(soda == 1)
            {
                FlavorCustomization flavor = new FlavorCustomization();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(flavor);
            }
            else
            {
                SizeCustomization size = new SizeCustomization();
                size.SideOrDrink(1);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(size);
            }
        }

        void RequestsBackButton(object sender, RoutedEventArgs es)
        {
            DrinksMenu drink = new DrinksMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(drink);
        }

        public void IsSodaOrNot(int IsSoda)
        {
            soda = IsSoda;
        }

        public void EnableDisableDrink(int enableDisable)
        {
            if(enableDisable == 0)
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
            }
            else if (enableDisable == 1)
            {
                lemonCheck.IsEnabled = false;
            }
            else
            {
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
            }
        }
    }
}
