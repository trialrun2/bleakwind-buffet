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
        public FlavorCustomization()
        {
            InitializeComponent();
        }
        
        void ChooseFlavor(object sender, RoutedEventArgs e)
        {

        }
        void FlavorNextButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization size = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            size.SideOrDrink(2);
            order.Swap(size);
        }
        void FlavorBackButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }
    }
}
