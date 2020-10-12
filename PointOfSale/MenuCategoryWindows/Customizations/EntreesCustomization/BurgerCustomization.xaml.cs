/*
 * Author: Zane Myers
 * Class name: BurgerCustomization.cs
 * Purpose: Initializes BurgerCustomization and handles events for the menu
 */

using BleakwindBuffet.Data.Entrees;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.MenuCategoryWindows.Customizations.EntreesCustomization
{
    /// <summary>
    /// Interaction logic for BurgerCustomization.xaml
    /// </summary>
    public partial class BurgerCustomization : UserControl
    {
        //creates new variables to modify and or pass in
        public BriarheartBurger bb = new BriarheartBurger();
        public DoubleDraugr dd = new DoubleDraugr();
        public ThalmorTriple tt = new ThalmorTriple();

        //private int to hold the type of burger we want
        private int burgerType;

        /// <summary>
        /// initializes burger customization
        /// </summary>
        public BurgerCustomization()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// event handler for the add to order button changes screen back to main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddBurgerButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }

        /// <summary>
        /// event handler for the back button changes sreen back to entree menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BurgersBackButton(object sender, RoutedEventArgs e)
        {
            EntreesMenu entrees = new EntreesMenu();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(entrees);
        }

        /// <summary>
        /// called when burger customization is initialized to determine what type of burger we want, enables or disables, checks or unchecks the proper 
        /// boxes for the assigned burger
        /// </summary>
        /// <param name="enableDisable"></param>
        public void EnableDisableBurger(int enableDisable)
        {
            burgerType = enableDisable;
            if (enableDisable == 0)//if it's a briarheart burger
            {
                tomatoCheck.IsEnabled = false;
                baconCheck.IsEnabled = false;
                mayoCheck.IsEnabled = false;
                lettuceCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
                tomatoCheck.IsChecked = false;
                baconCheck.IsChecked = false;
                mayoCheck.IsChecked = false;
                lettuceCheck.IsChecked = false;
                eggCheck.IsChecked = false;
            }
            else if(enableDisable == 1)// if it's a double draugr
            {
                baconCheck.IsEnabled = false;
                eggCheck.IsEnabled = false;
                baconCheck.IsChecked = false;
                eggCheck.IsChecked = false;
            }
            else // if its a thalmor triple
            {
            }
        }

        /// <summary>
        /// event handler for bun checkbox sets associated burgers bun property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBunSelect(object sender, RoutedEventArgs e)
        {
            if(burgerType == 0)
            {
                bb.Bun = (bool)bunCheck.IsChecked;
                DataContext = bb;
            }
            else if(burgerType == 1)
            {
                dd.Bun = (bool)bunCheck.IsChecked;
                DataContext = dd;
            }
            else
            {
                tt.Bun = (bool)bunCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for ketchup checkbox sets associated burgers ketchup property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnKetchupSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 0)
            {
                bb.Ketchup = (bool)ketchupCheck.IsChecked;
                DataContext = bb;
            }
            else if (burgerType == 1)
            {
                dd.Ketchup = (bool)ketchupCheck.IsChecked;
                DataContext = dd;
            }
            else
            {
                tt.Ketchup = (bool)ketchupCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for mustard checkbox sets associated burgers mustard property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnMustardSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 0)
            {
                bb.Mustard = (bool)mustardCheck.IsChecked;
                DataContext = bb;
            }
            else if (burgerType == 1)
            {
                dd.Mustard = (bool)mustardCheck.IsChecked;
                DataContext = dd;
            }
            else
            {
                tt.Mustard = (bool)mustardCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for pickle checkbox sets associated burgers pickle property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPickleSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 0)
            {
                bb.Pickle = (bool)pickleCheck.IsChecked;
                DataContext = bb;
            }
            else if (burgerType == 1)
            {
                dd.Pickle = (bool)pickleCheck.IsChecked;
                DataContext = dd;
            }
            else
            {
                tt.Pickle = (bool)pickleCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for cheese checkbox sets associated burgers cheese property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCheeseSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 0)
            {
                bb.Cheese = (bool)cheeseCheck.IsChecked;
                DataContext = bb;
            }
            else if (burgerType == 1)
            {
                dd.Cheese = (bool)cheeseCheck.IsChecked;
                DataContext = dd;
            }
            else
            {
                tt.Cheese = (bool)cheeseCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for lettuce checkbox sets associated burgers lettuce property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnLettuceSelect(object sender, RoutedEventArgs e)
        {
            if(burgerType == 1)
            {
                dd.Lettuce = (bool)lettuceCheck.IsChecked;
                DataContext = dd;
            }
            else if(burgerType == 2) 
            {
                tt.Lettuce = (bool)lettuceCheck.IsChecked;
                DataContext = tt;
            }
            else { }
        }

        /// <summary>
        /// event handler for tomato checkbox sets associated burgers tomato property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnTomatoSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 1)
            {
                dd.Tomato = (bool)tomatoCheck.IsChecked;
                DataContext = dd;
            }
            else if (burgerType == 2)
            {
                tt.Tomato = (bool)tomatoCheck.IsChecked;
                DataContext = tt;
            }
            else { }
        }

        /// <summary>
        /// event handler for mayo checkbox sets associated burgers mayo property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnMayoSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 1)
            {
                dd.Mayo = (bool)mayoCheck.IsChecked;
                DataContext = dd;
            }
            else if (burgerType == 2)
            {
                tt.Mayo = (bool)mayoCheck.IsChecked;
                DataContext = tt;
            }
            else { }
        }

        /// <summary>
        /// event handler for bacon checkbox sets tt's bacon property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnBaconSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 2)
            {
                tt.Bacon = (bool)baconCheck.IsChecked;
                DataContext = tt;
            }
        }

        /// <summary>
        /// event handler for egg checkbox sets tt's egg property to the checkbox's ischecked property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnEggSelect(object sender, RoutedEventArgs e)
        {
            if (burgerType == 2)
            {
                tt.Egg = (bool)eggCheck.IsChecked;
                DataContext = tt;
            }
        }
    }
}
