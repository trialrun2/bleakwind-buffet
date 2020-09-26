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
        public TBoneCustomization()
        {
            InitializeComponent();
        }

        void AddTBoneToOrderButton(object sender, RoutedEventArgs e)
        {

        }

        void TBoneBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }
    }
}
