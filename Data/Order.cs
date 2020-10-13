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

        private double salesTaxRate = 0.12;

        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
            }
        }

        private double price;
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

        private double tax;
        public double Tax
        {
            get
            {
                tax = 0;
                tax = SalesTaxRate * Subtotal;
                return tax;
            }
        }

        private double total;
        public double Total
        {
            get
            {
                total = 0;
                total = Subtotal + Tax;
                return total;
            }
        }

        private uint calories = 0;
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

        private static int nextOrderNumber = 1;

        public int Number
        {
            get
            {
                int number = nextOrderNumber;
                nextOrderNumber = nextOrderNumber + 1;
                return number;     
            }
        }

        void CollectionChangedListner(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Order item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (Order item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset sot supported");
            }
        }

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
