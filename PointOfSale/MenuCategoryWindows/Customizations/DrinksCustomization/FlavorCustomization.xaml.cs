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
        /// <summary>
        /// initializes flavor customization
        /// </summary>
        public FlavorCustomization()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// event handler for the flavor radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChooseFlavor(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// event handler for the next button lets size customization know where to return to
        /// and changes screen to size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorNextButton(object sender, RoutedEventArgs e)
        {
            SizeCustomization size = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            size.SideOrDrink(2);
            order.Swap(size);
        }

        /// <summary>
        /// event handler for the back button changes screen back to drink special requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorBackButton(object sender, RoutedEventArgs e)
        {
            SpecialRequestCustomizations src = new SpecialRequestCustomizations();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(src);
        }
    }
}
