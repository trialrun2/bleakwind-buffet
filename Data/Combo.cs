/*
 * Author: Zane Myers
 * Class name: Combo.cs
 * Purpose: 
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class Combo : ObservableCollection<Combo>, IOrderItem, INotifyPropertyChanged
    {
        public PropertyChangedEventHandler PropertyChanged;

        private Drink drank;

        public Drink DrinkCombo
        {
            get => drank;
            set
            {
                CollectionChanged -= CollectionChangedListner;
                drank = value;
                CollectionChanged += CollectionChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DrinkCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Entree entre;
        public Entree EntreeCombo
        {
            get => entre;
            set
            {
                CollectionChanged -= CollectionChangedListner;
                entre = value;
                CollectionChanged += CollectionChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EntreeCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Side sid;
        public Side SideCombo
        {
            get => sid;
            set
            {
                CollectionChanged -= CollectionChangedListner;
                sid = value;
                CollectionChanged += CollectionChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public double Price
        {
            get => SideCombo.Price + DrinkCombo.Price + EntreeCombo.Price - 1;
        }

        private uint cal;
        public uint Calories
        {
            get => SideCombo.Calories + DrinkCombo.Calories + EntreeCombo.Calories;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                instructions.Add($"{EntreeCombo.ToString()}\n, - {EntreeCombo.SpecialInstructions}, \n {SideCombo.ToString()}, \n - {SideCombo.SpecialInstructions}, \n {DrinkCombo.ToString()}, \n - {DrinkCombo.SpecialInstructions}");
                return instructions;//return the list
            }
        }

        void CollectionChangedListner(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Combo item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(Combo item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListner;
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    foreach (Combo item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListner;
                    }
                    foreach (Combo item in e.OldItems)
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
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
