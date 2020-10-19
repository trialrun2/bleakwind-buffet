using BleakwindBuffet.Data;
using RoundRegister;
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

namespace PointOfSale.RegisterControls
{
    /// <summary>
    /// Interaction logic for PaymentOptionsWindow.xaml
    /// </summary>
    public partial class PaymentOptionsWindow : UserControl
    {
        private RegisterViewModel register;
        public PaymentOptionsWindow(RegisterViewModel rvm)
        {
            InitializeComponent();
            register = rvm;
        }

        void CreditDebitButton(object sender, RoutedEventArgs e)
        {
            
                MessageBox.Show(register.PayWithCard());
            
        }

        void CashButton(object sender, RoutedEventArgs e)
        {
            PayingInCashWindow cashPayment = new PayingInCashWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(cashPayment);
        }

        void ReturnButton(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            OrderWindow order = this.FindAncestor<OrderWindow>();
            order.Swap(menu);
        }
    }
}
