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
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Drink drank;

        public Drink DrinkCombo
        {
            get => drank;
            set
            {
                DrinkCombo.PropertyChanged -= PropertyItemChangedListner;
                drank = value;
                DrinkCombo.PropertyChanged += PropertyItemChangedListner;
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
                entre.PropertyChanged -= PropertyItemChangedListner;
                entre = value;
                entre.PropertyChanged += PropertyItemChangedListner;
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
                sid.PropertyChanged -= PropertyItemChangedListner;
                sid = value;
                sid.PropertyChanged += PropertyItemChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public double Price
        {
            get => sid.Price + drank.Price + entre.Price - 1;
        }

        private uint cal;

        public uint Calories
        {
            get => sid.Calories + drank.Calories + entre.Calories;
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                instructions.Add($"{entre.ToString()}\n, - {entre.SpecialInstructions}, \n {sid.ToString()}, \n - {sid.SpecialInstructions}, \n {drank.ToString()}, \n - {drank.SpecialInstructions}");
                return instructions;//return the list
            }
        }

        void PropertyItemChangedListner(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            if(e.PropertyName == "Calories")
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}
