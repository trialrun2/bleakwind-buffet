﻿/*
*FileName: AretinoAppleJuice.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object AretinoAppleJuice
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged
    {
        List<string> instructions = new List<string>();//creates new list

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 0.62;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 44;


        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public override Size Size
        {
            get => cupSize;//gets cupSize
            set
            {
                cupSize = value;//sets cupSize to value
                if (cupSize == Size.Large)//if cupSize is equal to Large
                {
                    price = 1.01;//set price equal to 1.01
                    calories = 132;//set calories equal to 132
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 0.87;//set price equal to 0.87
                    calories = 88;//set calories equal to 88
                }
                else
                {
                    price = 0.62;//set price back to default
                    calories = 44;//set calories back to default
                }
                PropChanged("Price");
                PropChanged("Calories");
                PropChanged("Size");
                PropChanged("Name");
                PropChanged("SpecialInstructions");
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
        /// gets and sats calories
        /// </summary>
        public override uint Calories
        {
            get { return calories; }//gets/returns calories
        }

        /// <summary>
        /// private backing variable for ice
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// gets and sets ice
        /// </summary>
        public bool Ice
        {
            get => ice;//gets boolean value for ice
            set
            {
                ice = value;//sets boolean value of ice to value
                if (Ice) instructions.Add("Add ice");//if ice is true, add ice
                else { instructions.Remove("Add ice"); }// if its false remove add ice
                PropChanged("Ice");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice
        /// </summary>
        /// <returns>
        /// a list of special instructions
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get => instructions;
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the meal
        /// </returns>
        public override string ToString()
        {
            string name = $"{Size} Aretino Apple Juice";

            if (Ice) name += "\n - Add Ice";

            return name;
        }

        /// <summary>
        /// a string holding the description of the object
        /// </summary>
        public override string Description
        {
            get { return "Fresh squeezed apple juice."; }
        }
    }
}
