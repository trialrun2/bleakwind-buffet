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
    /// <summary>
    /// Class that creates the Combo Object
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // private backing variable for DrinkCombo
        private Drink drank;

        /// <summary>
        /// Drink property for the combo method 
        /// </summary>
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

        // private backing variable for EntreeCombo
        private Entree entre;

        /// <summary>
        /// Entree Property for the combo object
        /// </summary>
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

        // private backing variable for sideCombo
        private Side sid;

        /// <summary>
        /// Side property for combo object
        /// </summary>
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

        /// <summary>
        /// price property for combo object
        /// </summary>
        public double Price
        {
            get => sid.Price + drank.Price + entre.Price - 1;
        }

        /// <summary>
        /// calories property for combo object 
        /// </summary>
        public uint Calories
        {
            get => sid.Calories + drank.Calories + entre.Calories;
        }

        /// <summary>
        /// specialInstructions method for combo object
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                instructions.Add($"{entre.ToString()}\n, - {entre.SpecialInstructions}, \n {sid.ToString()}, \n - {sid.SpecialInstructions}, \n {drank.ToString()}, \n - {drank.SpecialInstructions}");
                return instructions;//return the list
            }
        }

        /// <summary>
        ///  event listner for the como objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
