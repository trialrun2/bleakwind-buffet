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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using PointOfSale;
using PointOfSale.MenuCategoryWindows.Customizations;

namespace PointOfSale.MenuCategoryWindows
{
    /// <summary>
    /// Interaction logic for SidesMenu.xaml
    /// </summary>
    public partial class SidesMenu : UserControl
    {
        public SidesMenu()
        {
            InitializeComponent();
        }

        void FriesButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrink(0);
            order.Swap(custom);
        }

        void MiraakButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrink(0);
            order.Swap(custom);
        }

        void GritsButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrink(0);
            order.Swap(custom);
        }

        void SaladButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrink(0);
            order.Swap(custom);

            
        }

        void SidesBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }
    }
}
