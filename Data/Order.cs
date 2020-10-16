/*
 * Author: Zane Myers
 * Class name: Order.cs
 * Purpose: 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>
    {
        // default sales tax rate
        private double salesTaxRate = 0.12;

        /// <summary>
        /// public property to get and set the sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
            }
        }

        //private backing variable for subtotal
        private double price;

        /// <summary>
        /// public property for the subtotal of the object
        /// </summary>
        public double Subtotal
        {
            get
            {
                price = 0;
                foreach(IOrderItem item in this)
                {
                    price = price +  item.Price;
                }
                return price;
            }
        }

        //private backing variable for the tax property
        private double tax;

        /// <summary>
        /// public property Tax for the object
        /// </summary>
        public double Tax
        {
            get
            {
                tax = 0;
                tax = SalesTaxRate * Subtotal;
                return tax;
            }
        }

        //private backing variable for the total price
        private double total;

        /// <summary>
        /// public property for the total price of the object
        /// </summary>
        public double Total
        {
            get
            {
                total = 0;
                total = Subtotal + Tax;
                return total;
            }
        }

        //private backing variable for calories property
        private uint calories = 0;

        /// <summary>
        /// public property for the calories of the object
        /// </summary>
        public uint Calories
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    calories = calories + item.Calories;
                }
                return calories;
            }
        }

        //private static backing variable for the order number
        private static int nextOrderNumber = 0;

        /// <summary>
        /// public property for the order number of the object
        /// </summary>
        public int Number
        {
            get
            {
                int number = nextOrderNumber;
                return number;     
            }
        }

        /// <summary>
        /// public order method adds a collectiochangedlistner and increments the order number
        /// </summary>
        public Order()
        {
            CollectionChanged += CollectionChangedListner;
            nextOrderNumber = nextOrderNumber + 1;
        }

        /// <summary>
        /// Event handler for collection changed listner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListner(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset sot supported");
            }
        }

        /// <summary>
        /// event handler for the collection item changed listner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListner(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
