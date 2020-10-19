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

        public Combo()
        {
            price = 0;
            cals = 0;
            name = "";
        }
        /*public Combo (Entree entree)
        {
            entre = entree;
            price = entre.Price;
            cals = entre.Calories;
            name = $"{entre.ToString()}";
        }
        public Combo(Entree entree, Drink drink)
        {
            entre = entree;
            drank = drink;
            price = entre.Price + drank.Price - 1;
            cals = entre.Calories + drank.Calories;
            name = $"{entre.ToString()} \n{drank.ToString()}";
        }
        public Combo (Entree entree, Drink drink, Side side)
        {
            entre = entree;
            drank = drink;
            sid = side;
            price = sid.Price + drank.Price + entre.Price - 1;
            cals = sid.Calories + drank.Calories + entre.Calories;
            name = $"{entre.ToString()} \n {sid.ToString()} \n {drank.ToString()}";
        }*/

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
                if (entre != null) DrinkCombo.PropertyChanged -= PropertyItemChangedListner;

                drank = value;
                DrinkCombo.PropertyChanged += PropertyItemChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DrinkCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
                if(entre != null) entre.PropertyChanged -= PropertyItemChangedListner;

                entre = value;
                entre.PropertyChanged += PropertyItemChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EntreeCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
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
                if (entre != null) sid.PropertyChanged -= PropertyItemChangedListner;

                sid = value;
                sid.PropertyChanged += PropertyItemChangedListner;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideCombo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }


        private double price;
        /// <summary>
        /// price property for combo object
        /// </summary>
        public double Price
        {
            get => price;
            set
            {
                price = value;
            }
        }


        private uint cals;
        /// <summary>
        /// calories property for combo object 
        /// </summary>
        public uint Calories
        {
            get => cals;
            set
            {
                cals = value;
            }
        }

        /// <summary>
        /// specialInstructions method for combo object
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                instructions.Add($"{entre.ToString()} \n {sid.ToString()} \n {drank.ToString()}");
                return instructions;//return the list
            }
        }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            if(e.PropertyName == "Name")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
    }
}
