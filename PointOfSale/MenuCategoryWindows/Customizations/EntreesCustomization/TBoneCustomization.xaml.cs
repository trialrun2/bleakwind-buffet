﻿/*
 * Author: Zane Myers
 * Class name: TBoneCustomization.cs
 * Purpose: Initializes TBoneCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for TBoneCustomization.xaml
    /// </summary>
    public partial class TBoneCustomization : UserControl
    {
        /// <summary>
        /// initializes tbone customization
        /// </summary>
        public TBoneCustomization(IOrderItem ttb)
        {
            InitializeComponent();
            DataContext = ttb;
        }

        /// <summary>
        /// event handler for add button returns screen to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneButton(object sender, RoutedEventArgs e)
        {
            OrderWindow order = this.FindAncestor<OrderWindow>();
            MenuWindow menu = new MenuWindow();
            order.Swap(menu);     
        }

        /// <summary>
        /// event handler for back button changes screen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TBoneBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }
    }
}
