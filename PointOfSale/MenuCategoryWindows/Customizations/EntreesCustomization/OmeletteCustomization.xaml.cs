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
    /// Interaction logic for OmeletteCustomization.xaml
    /// </summary>
    public partial class OmeletteCustomization : UserControl
    {
        //new variable to modify and pass in
        public GardenOrcOmelette goo = new GardenOrcOmelette();

        /// <summary>
        /// initializes omelett customization
        /// </summary>
        public OmeletteCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for the add to order button changes screen back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddOmeletteButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

        /// <summary>
        /// event handler for the back button changes screen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OmelettesBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }

        /// <summary>
        /// event handler for broccoli checkbox sets goo's broccoli property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBroccoliSelect(object sender, RoutedEventArgs e)
        {
            goo.Broccoli = (bool)broccoliCheck.IsChecked;
            DataContext = goo;
        }

        /// <summary>
        /// event handler for mushrooms checkbox sets goo's mushroom property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnMushroomsSelect(object sender, RoutedEventArgs e)
        {
            goo.Mushrooms = (bool)mushroomsCheck.IsChecked;
            DataContext = goo;
        }

        /// <summary>
        /// event handler for tomato checkbox sets goo's tomato property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTomatoSelect(object sender, RoutedEventArgs e)
        {
            goo.Tomato = (bool)tomatoCheck.IsChecked;
            DataContext = goo;
        }

        /// <summary>
        /// event handler for cheddar checkbox sets goo's cheddar property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCheddarSelect(object sender, RoutedEventArgs e)
        {
            goo.Cheddar = (bool)cheddarCheck.IsChecked;
            DataContext = goo;
        }

    }
}
