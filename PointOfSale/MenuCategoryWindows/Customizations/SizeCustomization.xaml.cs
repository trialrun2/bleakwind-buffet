/*
 * Author: Zane Myers
 * Class name: SizeCustomization.cs
 * Purpose: Initializes SizeCustomization and handles events for the menu
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization;
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

namespace PointOfSale.MenuCategoryWindows.Customizations
{
    /// <summary>
    /// Interaction logic for SizeCustomization.xaml
    /// </summary>
    public partial class SizeCustomization : UserControl
    {
        //private int variable to allow size to know where to return if back is pressed
        private int sideOrDrinkType;
        // object variable to hold the incoming object;
        object obj = null;

        public Order orderList = new Order();

        /// <summary>
        /// initializes size customization disables the add item button
        /// </summary>
        public SizeCustomization()
        {
            InitializeComponent();
            addItemButton.IsEnabled = false;
        }

        /// <summary>
        /// event handler for the radio buttons enables the add item button, and chooses the size for the given object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeOfItem(object sender, RoutedEventArgs e)
        {
            addItemButton.IsEnabled = true;
            if (sideOrDrinkType == 0)//sailor soda
            {
                SailorSoda ss = (SailorSoda)obj;
                if (smallRadio.IsChecked == true) { ss.CupSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { ss.CupSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { ss.CupSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = ss;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 1)//Candleheart coffee
            {
                CandlehearthCoffee chc = (CandlehearthCoffee)obj;
                if (smallRadio.IsChecked == true) { chc.CupSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { chc.CupSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { chc.CupSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = chc;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 2)//warrior water
            {
                WarriorWater ww = (WarriorWater)obj;
                if (smallRadio.IsChecked == true) { ww.CupSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { ww.CupSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { ww.CupSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = ww;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 3)// aretino Apple juice
            {
                AretinoAppleJuice aj = (AretinoAppleJuice)obj;
                if (smallRadio.IsChecked == true) { aj.CupSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { aj.CupSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { aj.CupSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = aj;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 4)// markarth milk
            {
                MarkarthMilk mm = (MarkarthMilk)obj;
                if (smallRadio.IsChecked == true) { mm.CupSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { mm.CupSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { mm.CupSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = mm;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 5)// dragonborn waffle fries
            {
                DragonbornWaffleFries dwf = (DragonbornWaffleFries)obj;
                if (smallRadio.IsChecked == true) { dwf.SideSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { dwf.SideSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { dwf.SideSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = dwf;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 6)// fried miraak
            {
                FriedMiraak fm = (FriedMiraak)obj;
                if (smallRadio.IsChecked == true) { fm.SideSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { fm.SideSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { fm.SideSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = fm;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 7) // mad otar grits
            {
                MadOtarGrits mog = (MadOtarGrits)obj;
                if (smallRadio.IsChecked == true) { mog.SideSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { mog.SideSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { mog.SideSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = mog;
                DataContext = obj;
            }
            else if (sideOrDrinkType == 8) // vokun salad
            {
                VokunSalad vs = (VokunSalad)obj;
                if (smallRadio.IsChecked == true) { vs.SideSize = BleakwindBuffet.Data.Enums.Size.Small; }
                else if (mediumRadio.IsChecked == true) { vs.SideSize = BleakwindBuffet.Data.Enums.Size.Medium; }
                else if (largeRadio.IsChecked == true) { vs.SideSize = BleakwindBuffet.Data.Enums.Size.Large; }
                else { }
                obj = vs;
                DataContext = obj;
            }
            else { }

        }

        /// <summary>
        /// event handler for the back button chooses to change the screen to sides menu, drinks customizion, or flavor
        /// customization based on the private variable sideOrd drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeBackButton(object sender, RoutedEventArgs e)
        {
            if(sideOrDrinkType == 5 || sideOrDrinkType == 6 || sideOrDrinkType == 7 || sideOrDrinkType == 8)// if it's a side
            {
                SidesMenu swap = new SidesMenu();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(swap);
            }
            else if(sideOrDrinkType == 0)// if its a drink and a soda
            {
                FlavorCustomization swap = new FlavorCustomization();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                order.Swap(swap);
            }
            else // if its any other drink type
            {
                DrinkCustomizations swap = new DrinkCustomizations();
                OrderWindow order = this.FindAncestor<OrderWindow>();
                swap.EnableDisableDrink(sideOrDrinkType);
                order.Swap(swap);
            }
            
        }

        /// <summary>
        /// event handler for the add to order button returns to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
            orderList.Add((IOrderItem) obj);
        }

        /// <summary>
        /// called when size customization is initialized to set sideOrDrink variable, and obj to item variable
        /// </summary>
        /// <param name="isSideOrDrink"></param>
        public void SideOrDrinkType(int isSideOrDrinkType, object item)
        {
            sideOrDrinkType = isSideOrDrinkType;
            obj = item;
        }
    }
}
