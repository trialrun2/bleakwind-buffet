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
        public OrderWindow()
        {
            InitializeComponent();
        }

        void PriorOrder(object sender, RoutedEventArgs e)
        {

        }

        void NextOrder(object sender, RoutedEventArgs e)
        {

        }

        void AddNewOrder(object sender, RoutedEventArgs e)
        {

        }
        public void Swap(object swap)
        {
                menuItems.Child = (UIElement)swap;
        }
    }
}
