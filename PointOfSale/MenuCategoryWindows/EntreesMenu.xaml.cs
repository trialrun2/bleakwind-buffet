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
        /// <summary>
        /// initializes the entree menu
        /// </summary>
        public EntreesMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the briarheart burger button lets the burger customization know what to disable
        /// changes the screen the burger customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BriarheartButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(0);
            order.Swap(bc);
        }

        /// <summary>
        /// event handler for the Double Draugr button lets the burger customization know what to disable
        /// changes the screen the burger customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(1);
            order.Swap(bc);
        }

        /// <summary>
        /// event handler for the omelette button changes screen to omelette customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OmeletteButton(object sender, RoutedEventArgs e)
        {
            OmeletteCustomization omelette = new OmeletteCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(omelette);
        }

        /// <summary>
        /// event handler for the poacher button changes screen to poacher customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PoacherButton(object sender, RoutedEventArgs e)
        {
            PoacherCustomization poacher = new PoacherCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(poacher);
        }

        /// <summary>
        /// event handler for the skeleton button changes screen to skeleton customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SkeletonButton(object sender, RoutedEventArgs e)
        {
            SkeletonCustomization skeleton = new SkeletonCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(skeleton);
        }

        /// <summary>
        /// event handler for the Thalmor Triple button lets the burger customization know what to disable
        /// changes the screen the burger customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TripleButton(object sender, RoutedEventArgs e)
        {
            BurgerCustomization bc = new BurgerCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            bc.EnableDisableBurger(2);
            order.Swap(bc);
        }

        /// <summary>
        /// event handler for the tbone button changes screen to tbone customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TBoneButton(object sender, RoutedEventArgs e)
        {
            TBoneCustomization tbc = new TBoneCustomization();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(tbc);
        }

        /// <summary>
        /// event handler for the entrees back button changes screen back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EntreesBackButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

    }
}

