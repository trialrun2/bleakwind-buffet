/*
 * Author: Zane Myers
 * Class name: EntreesMenu.cs
 * Purpose: Initializes EntreesMenu and handles events for the menu
 */

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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

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
            BriarheartBurger bb = new BriarheartBurger();
            BurgerCustomization bc = new BurgerCustomization(bb, 0);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(bb);
            }
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
            DoubleDraugr dd = new DoubleDraugr();
            BurgerCustomization bc = new BurgerCustomization(dd, 1);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(dd);
            }
            order.Swap(bc);
        }

        /// <summary>
        /// event handler for the omelette button changes screen to omelette customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OmeletteButton(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            OmeletteCustomization omelette = new OmeletteCustomization(goo);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(goo);
            }
            order.Swap(omelette);
        }

        /// <summary>
        /// event handler for the poacher button changes screen to poacher customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PoacherButton(object sender, RoutedEventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            PoacherCustomization poacher = new PoacherCustomization(pp);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(pp);
            }
            order.Swap(poacher);
        }

        /// <summary>
        /// event handler for the skeleton button changes screen to skeleton customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SkeletonButton(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            SkeletonCustomization skeleton = new SkeletonCustomization(ss);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(ss);
            }
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
            ThalmorTriple tt = new ThalmorTriple();
            BurgerCustomization bc = new BurgerCustomization(tt, 2);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(tt);
            }
            order.Swap(bc);
        }

        /// <summary>
        /// event handler for the tbone button changes screen to tbone customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TBoneButton(object sender, RoutedEventArgs e)
        {
            ThugsT_Bone ttb = new ThugsT_Bone();
            TBoneCustomization tbc = new TBoneCustomization(ttb);
            OrderWindow order = this.FindAncestor<OrderWindow>();
            if (DataContext is Order orders)
            {
                orders.Add(ttb);
            }
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

