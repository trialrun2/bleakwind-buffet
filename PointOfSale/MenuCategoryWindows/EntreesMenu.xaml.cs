using PointOfSale.MenuCategoryWindows.Customizations.EntreesCustomization;
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

namespace PointOfSale.MenuCategoryWindows
{
    /// <summary>
    /// Interaction logic for EntreesMenu.xaml
    /// </summary>
    public partial class EntreesMenu : UserControl
    {
        public EntreesMenu()
        {
            InitializeComponent();
        }
        void BriarheartButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(0);
            order.Swap(bc);
        }

        void DoubleButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(1);
            order.Swap(bc);
        }

        void OmeletteButton(object sender, RoutedEventArgs e)
        {
            OmeletteCustomization omelette = new OmeletteCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(omelette);
        }
        void PoacherButton(object sender, RoutedEventArgs e)
        {
            PoacherCustomization poacher = new PoacherCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(poacher);
        }
        void SkeletonButton(object sender, RoutedEventArgs e)
        {
            SkeletonCustomization skeleton = new SkeletonCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(skeleton);
        }
        void TripleButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(2);
            order.Swap(bc);
        }
        void TBoneButton(object sender, RoutedEventArgs e)
        {
            TBoneCustomization tbc = new TBoneCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(tbc);
        }
        void EntreesBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

    }
}

