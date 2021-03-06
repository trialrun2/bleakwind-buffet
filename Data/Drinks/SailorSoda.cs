﻿/*
*FileName: SailorSoda.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object SailorSoda
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for sailor soda, creates properties for it
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        List<string> instructions = new List<string>();//creates new list

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for flavor
        /// </summary>
        private Flavor flavor = Flavor.Cherry;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.42;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 117;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public override Size Size
        {
            get => cupSize;//gets cupSize
            set
            {
                cupSize = value;//sets cupSize to value
                if (cupSize == Size.Large)//if cupSize is Large
                {
                    calories = 205;//set calories equal to 205
                    price = 2.07;//set price equal to 2.07
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 153;//set calories equal to 153
                    price = 1.74;//set price equal to 1.74
                }
                else
                {
                    calories = 117;//set calories back to default
                    price = 1.42;//set price back to default
                }
                PropChanged("Size");
                PropChanged("Price");
                PropChanged("Calories");
                PropChanged("Name");
                PropChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// gets and sets flavor
        /// </summary>
        public Flavor SodaFlavor
        {
            get => flavor;//gets flavor
            set
            {
                flavor = value;//sets flavor to value
                PropChanged("Flavor");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// gets and sets price
        /// </summary>
        public override double Price
        {
            get { return price; }//gets/returns price
        }

        /// <summary>
        /// gets and calories
        /// </summary>
        public override uint Calories
        {
            get { return calories; }//gets/returns calories
        }

        /// <summary>
        /// private backing variable for ice
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// gets and sets ice
        /// </summary>
        public bool Ice
        {
            get => ice;//gets boolean value for ice
            set
            {
                ice = value;//sets boolean value of ice to value
                PropChanged("Ice");
                if (!Ice) instructions.Add("Hold ice");//if ice is false, hold ice
                else instructions.Remove("Hold ice");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice
        /// </summary>
        /// <returns>
        /// a list of special instructions for the drink
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get => instructions;
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the drink
        /// </returns>
        public override string ToString()
        {
            string name = $"{Size} {flavor} Sailor Soda";

            if (!Ice) name += "\n   - Hold ice";

            return name;
        }

        /// <summary>
        /// a string holding the description of the object
        /// </summary>
        public override string Description
        {
            get { return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice."; }
        }
    }
}
