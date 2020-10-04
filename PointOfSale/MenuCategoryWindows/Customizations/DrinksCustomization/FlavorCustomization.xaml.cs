using BleakwindBuffet.Data.Drinks;
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
        //variable to hold soda passedIn and pass it on
        SailorSoda passIn = null;

        /// <summary>
        /// initializes flavor customization and disables next button
        /// </summary>
        public FlavorCustomization()
        {
            InitializeComponent();
            nextButton.IsEnabled = false;
        }
        
        /// <summary>
        /// event handler for the flavor radio buttons checks which one is checked and sets the flavor property of passIn
        /// to that flavor, then enables the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChooseFlavor(object sender, RoutedEventArgs e)
        {
            nextButton.IsEnabled = true;
            if (BBRadio.IsChecked == true)
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            }
            else if (GFRadio.IsChecked == true)
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            }
            else if(WMRadio.IsChecked == true)
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            }
            else if(PRadio.IsChecked == true)
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            }
            else if(LRadio.IsChecked == true)
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            }
            else
            {
                passIn.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            }
            DataContext = passIn;
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
            size.SideOrDrinkType(0, passIn);
            order.Swap(size);
        }

        /// <summary>
        /// event handler for the back button changes screen back to drink special requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorBackButton(object sender, RoutedEventArgs e)
        {
            DrinkCustomizations src = new DrinkCustomizations();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            src.EnableDisableDrink(0);
            order.Swap(src);
        }

        /// <summary>
        /// sets passIn to the object passedIn
        /// </summary>
        /// <param name="passedIn"></param>
        public void PassInSoda(object passedIn)
        {
            passIn = (SailorSoda)passedIn;
        }
    }
}
