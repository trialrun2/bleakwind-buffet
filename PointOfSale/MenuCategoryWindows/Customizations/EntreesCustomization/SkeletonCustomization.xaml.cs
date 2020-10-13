/*
 * Author: Zane Myers
 * Class name: SkeletonCustomization.cs
 * Purpose: Initializes SkeletonCustomization and handles events for the menu
 */

using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
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
    /// Interaction logic for SkeletonCustomization.xaml
    /// </summary>
    public partial class SkeletonCustomization : UserControl
    {
        // creates new smokehouse skeleton object to modify
        SmokehouseSkeleton ss = new SmokehouseSkeleton();
       
        /// <summary>
        /// initializes skeleton customization
        /// </summary>
        public SkeletonCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for add to order button returns screen to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

        /// <summary>
        /// event handler for back button changes screen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SkeletonBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }
    }
}
