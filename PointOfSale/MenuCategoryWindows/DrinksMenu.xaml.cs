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
        public DrinksMenu()
        {
            InitializeComponent();
        }

        void AppleJuiceButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            src.EnableDisableDrink(0);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }

        void CoffeeButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            src.EnableDisableDrink(1);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }

        void MilkButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            src.EnableDisableDrink(0);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }

        void SodaButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            src.IsSodaOrNot(1);
            src.EnableDisableDrink(0);
            order.Swap(src);
        }

        void WaterButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            src.EnableDisableDrink(2);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }

        void DrinksBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }
    }
}
