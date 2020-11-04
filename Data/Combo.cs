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

        public Combo(Drink drink, Entree entree, Side side)
        {
            drank = drink;
            entre = entree;
            sid = side;
        }

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
                if(sid == null && drank == null && entre == null)
                {
                    price = 0;
                }
                else if (sid == null && drank == null)
                {
                    price = EntreeCombo.Price;
                }
                else if (sid == null)
                {
                    price = EntreeCombo.Price + DrinkCombo.Price;
                }
                else
                {
                    price = EntreeCombo.Price + DrinkCombo.Price + SideCombo.Price;
                }
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
                if (sid == null && drank == null && entre == null)
                {
                    cals = 0;
                }
                else if (sid == null && drank == null)
                {
                    cals = EntreeCombo.Calories;
                }
                else if (sid == null)
                {
                    cals = EntreeCombo.Calories + DrinkCombo.Calories;
                }
                else
                {
                    cals = EntreeCombo.Calories + DrinkCombo.Calories + SideCombo.Calories;
                }
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

        public string Name => throw new NotImplementedException();

        public override string ToString()
        {
           string name = "";
                
            if(entre != null)
            {
                name += EntreeCombo.ToString();
            }
            if(drank != null)
            {
                name += DrinkCombo.ToString();
            }
            if(sid != null)
            {
                name += SideCombo.ToString();
            }
            return name;
            
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
