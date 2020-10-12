/*
 * Author: Zane Myers
 * Class name: SidesMenu.cs
 * Purpose: Initializes SidesMenu and handles events for the menu
 */

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
        /// <summary>
        /// initializes the sides menu
        /// </summary>
        public SidesMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the fries button lets SizeCustomization know it's a side and 
        /// changes the screen to Size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriesButton(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrinkType(5, dwf);
            order.Swap(custom);
        }

        /// <summary>
        /// event handler for the Miraak button lets SizeCustomization know it's a side and 
        /// changes the screen to Size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MiraakButton(object sender, RoutedEventArgs e)
        {
            FriedMiraak fm = new FriedMiraak();
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrinkType(6, fm);
            order.Swap(custom);
        }

        /// <summary>
        /// event handler for the grits button lets SizeCustomization know it's a side and 
        /// changes the screen to Size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GritsButton(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrinkType(7, mog);
            order.Swap(custom);
        }

        /// <summary>
        /// event handler for the salad button lets SizeCustomization know it's a side and 
        /// changes the screen to Size customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SaladButton(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            SizeCustomization custom = new SizeCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            custom.SideOrDrinkType(8, vs);
            order.Swap(custom);

            
        }

        /// <summary>
        /// event handler for the back button changes the screen back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SidesBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }
    }
}
