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
    /// Interaction logic for PoacherCustomization.xaml
    /// </summary>
    public partial class PoacherCustomization : UserControl
    {
        //creates new variable to modify and pass in
        public PhillyPoacher pp = new PhillyPoacher();
        
        /// <summary>
        /// initializes poacher customization
        /// </summary>
        public PoacherCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for add button returns screen to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddPoacherButton(object sender, RoutedEventArgs e)
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
        void PoacherBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entree = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entree);
        }

        /// <summary>
        /// event handler for sirloin checkbox sets pp's sirloin property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSirloinSelect(object sender, RoutedEventArgs e)
        {
            pp.Sirloin = (bool)sirloinCheck.IsChecked;
            DataContext = pp;
        }

        /// <summary>
        /// event handler for onion checkbox sets pp's onion property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnOnionSelect(object sender, RoutedEventArgs e)
        {
            pp.Onion = (bool)onionCheck.IsChecked;
            DataContext = pp;
        }

        /// <summary>
        /// event handler for roll checkbox sets pp's roll property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnRollSelect(object sender, RoutedEventArgs e)
        {
            pp.Roll = (bool)rollCheck.IsChecked;
            DataContext = pp;
        }
    }
}
