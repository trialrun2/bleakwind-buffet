using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.MenuCategoryWindows.Customizations;
using PointOfSale.MenuCategoryWindows.Customizations.DrinksCustomization;
using PointOfSale.MenuCategoryWindows.Customizations.EntreesCustomization;
using PointOfSale.RegisterControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryWindow.xaml
    /// </summary>
    public partial class OrderSummaryWindow : UserControl
    {
        public OrderSummaryWindow()
        {
            InitializeComponent();
        }

        void RemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        void EditItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item)
                    {
                        if(item is BriarheartBurger bb)
                        {
                            BurgerCustomization bc = new BurgerCustomization(bb, 0);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is DoubleDraugr dd)
                        {
                            BurgerCustomization bc = new BurgerCustomization(dd, 1);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is ThalmorTriple tt)
                        {
                            BurgerCustomization bc = new BurgerCustomization(tt, 2);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is GardenOrcOmelette goo)
                        {
                            OmeletteCustomization bc = new OmeletteCustomization(goo);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is PhillyPoacher pp)
                        {
                            PoacherCustomization bc = new PoacherCustomization(pp);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is SmokehouseSkeleton shs)
                        {
                            SkeletonCustomization bc = new SkeletonCustomization(shs);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is ThugsT_Bone ttb)
                        {
                            TBoneCustomization bc = new TBoneCustomization(ttb);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is DragonbornWaffleFries dwf)
                        {
                            SizeCustomization bc = new SizeCustomization(5, dwf);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is FriedMiraak fm)
                        {
                            SizeCustomization bc = new SizeCustomization(6, fm);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is MadOtarGrits mog)
                        {
                            SizeCustomization bc = new SizeCustomization(7, mog);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is VokunSalad vs)
                        {
                            SizeCustomization bc = new SizeCustomization(8, vs);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is AretinoAppleJuice aj)
                        {
                            DrinkCustomizations bc = new DrinkCustomizations(aj, 3);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is CandlehearthCoffee chc)
                        {
                            DrinkCustomizations bc = new DrinkCustomizations(chc, 1);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is MarkarthMilk mm)
                        {
                            DrinkCustomizations bc = new DrinkCustomizations(mm, 4);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is SailorSoda ss)
                        {
                            DrinkCustomizations bc = new DrinkCustomizations(ss, 0);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                        if (item is WarriorWater ww)
                        {
                            DrinkCustomizations bc = new DrinkCustomizations(ww, 2);
                            OrderWindow orderList = this.FindAncestor<OrderWindow>();
                            orderList.Swap(bc);
                        }
                    }
                }
            }
        }
    }
}
