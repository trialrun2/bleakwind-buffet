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
        private int sideOrDrink;
        public SizeCustomization()
        {
            InitializeComponent();
        }
        void SizeOfSide(object sender, RoutedEventArgs e)
        {

        }
        void SizeOfSideBackButton(object sender, RoutedEventArgs e)
        {
            object swap = null;
            if(sideOrDrink == 0)
            {
                swap = new SidesMenu();
            }
            if(sideOrDrink == 1)
            {
                swap = new SpecialRequestCustomizations();
            }
            if(sideOrDrink == 2)
            {
                swap = new FlavorCustomization();
            }
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(swap);
        }

        void AddItemButton(object sender, RoutedEventArgs e)
        {

        }

        public void SideOrDrink(int isSideOrDrink)
        {
            sideOrDrink = isSideOrDrink;
        }
    }
}
