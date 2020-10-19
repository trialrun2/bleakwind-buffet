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
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        public CoinControl()
        {
            InitializeComponent();
        }

        //public static DependencyProperty CashValueProperty = DependencyProperty.Register("CashValue", typeof(), typeof(CashControl));

        // <summary>
        /// The DependencyProperty backing the Quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
                DependencyProperty.Register(
                    "Quantity",
                    typeof(int),
                    typeof(CoinControl),
                    new FrameworkPropertyMetadata(
                        0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /*public string CoinValue
        {
            get{return () GetValue(CoinValueProperty); }
            set { SetValue(CoinValueProeprty, value); }
        }*/

        /// <summary>
        /// The quantity of the bill denomination
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        void DecrementQuantity(object sender, RoutedEventArgs e)
        {
            Quantity--;
            //var userCash = this.FindAncestor<>();
            //userCash.Add();
        }

        void IncrementQuantity(object sender, RoutedEventArgs e)
        {
            Quantity++;
            //var userCash = this.FindAncestor<>();
            //userCash.Add();
        }
    }
}
