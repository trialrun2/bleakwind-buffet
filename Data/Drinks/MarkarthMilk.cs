/*
*FileName: MarkarthMilk.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object MarkarthMilk
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        List<string> instructions = new List<string>();//creates new list

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.05;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 56;

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
                    price = 1.22;//set price equal to 1.22
                    calories = 93;//set calories equal to 93
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.11;//set price equal to 1.11
                    calories = 72;//set calories equal to 72
                }
                else
                {
                    price = 1.05;//set price back to default
                    calories = 56;//set calories back to default
                }
                PropChanged("Size");
                PropChanged("Price");
                PropChanged("Calories");
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
                PropChanged("Ice");
                if (Ice) instructions.Add("Add ice");//if ice is true, add ice
                else instructions.Remove("Add ice");
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
            string name = $"{Size} Markarth Milk";

            if (Ice) name += "\n   - Add ice";

            return name;
        }
    }
}
