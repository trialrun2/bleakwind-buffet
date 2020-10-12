/*
 * Author: Zane Myers
 * Class name: Order.cs
 * Purpose: 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged, ICollection, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event CollectionChangeEventHandler CollectionChanged;

        public ICollection<IOrderItem> order;


        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }

            remove
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }
        }

        public void Add(IOrderItem item)
        {
            order.Add(item);
            CollectionChanged?.Invoke(this, new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
        }

        public void Remove(IOrderItem item)
        {
            order.Remove(item);
            CollectionChanged?.Invoke(this, new CollectionChangeEventArgs(CollectionChangeAction.Remove, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private double salesTaxRate = 0.12;

        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        private double price = 0;
        public double Subtotal
        {
            get
            {   
                foreach(IOrderItem item in order)
                {
                    price = price +  item.Price;
                }
                return price;
            }
        }

        public double Tax
        {
            get => SalesTaxRate * Subtotal;
        }

        public double Total
        {
            get => Subtotal + Tax;
        }

        private uint calories = 0;
        public uint Calories
        {
            get
            {
                foreach (IOrderItem item in order)
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

        private int count;
        public int Count
        {
            get
            {
                foreach (IOrderItem item in order)
                {
                    count +=  1;
                }
                return count;
            }
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();
    }
}
