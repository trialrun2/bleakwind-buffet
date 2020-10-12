/*
 * Author: Zane Myers
 * Class name: OrderWindow.cs
 * Purpose: Initializes and handles events for the OrderWindow wpf
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
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : UserControl
    {
        /// <summary>
        /// initializes the order window
        /// </summary>
        public OrderWindow()
        {
            InitializeComponent();
            DataContext = "Order";
        }

        /// <summary>
        /// event handler for the prior order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            
        }


        /// <summary>
        /// event handler for the add order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddNewOrder(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// event handler for the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// swaps the menuItems border child with the given object
        /// </summary>
        /// <param name="swap"></param> 
        public void Swap(object swap)
        {
                menuItems.Child = (UIElement)swap;
        }
    }
}
