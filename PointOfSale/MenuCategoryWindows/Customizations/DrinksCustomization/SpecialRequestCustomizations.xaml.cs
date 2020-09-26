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

namespace PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization
{
    /// <summary>
    /// Interaction logic for SpecialRequestCustomizations.xaml
    /// </summary>
    public partial class SpecialRequestCustomizations : UserControl
    {
        //private int variable used to determine where to go next
        private int soda = 0;

        /// <summary>
        /// initializes drink special requests
        /// </summary>
        public SpecialRequestCustomizations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event hadler for next button, changes to either flavor customization, or size customization based
        /// on the soda variables value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RequestsNextButton(object sender, RoutedEventArgs e)
        {
            
            if(soda == 1)//if it is a Sailor Soda
            {
                FlavorCustomization flavor = new FlavorCustomization();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(flavor);
            }
            else//if its not a soda
            {
                SizeCustomization size = new SizeCustomization();
                size.SideOrDrink(1);
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(size);
            }
        }

        /// <summary>
        /// event handler for the back button changes screen back to drink menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="es"></param>
        void RequestsBackButton(object sender, RoutedEventArgs es)
        {
            DrinksMenu drink = new DrinksMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(drink);
        }

        /// <summary>
        /// called when special requests customization is initialized to set soda
        /// </summary>
        /// <param name="IsSoda"></param>
        public void IsSodaOrNot(int IsSoda)
        {
            soda = IsSoda;
        }

        /// <summary>
        /// called when special requests is initialized to determine what to disable
        /// </summary>
        /// <param name="enableDisable"></param>
        public void EnableDisableDrink(int enableDisable)
        {
            if(enableDisable == 0)//if it's apple juice, milk, or soda
            {
                lemonCheck.IsEnabled = false;
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
            }
            else if (enableDisable == 1)// if it's coffee
            {
                lemonCheck.IsEnabled = false;
            }
            else// if its water
            {
                decafCheck.IsEnabled = false;
                creamCheck.IsEnabled = false;
            }
        }
    }
}
