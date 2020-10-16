/*
*FileName: CandlehearthCoffee.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object CandlehearthCoffee
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        List<string> instructions = new List<string>();//creates new list

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 0.75;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 7;

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
                    price = 1.75;//set price equal to 1.75
                    calories = 20;//set calories equal to 20
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.25;//set price equal to 1.25
                    calories = 10;//set calories equal to 10
                }
                else
                {
                    price = 0.75;//set price back to default
                    calories = 7;//set calories back to default
                }
                PropChanged("Size");
                PropChanged("Price");
                PropChanged("Calories");
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
                else { instructions.Remove("Add ice"); }
                PropChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// private backing variable for roomForCream
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// gets and sets roomForCream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;//gets boolean value for roomForCream
            set
            {
                roomForCream = value;//sets boolean value of roomForCream to value
                PropChanged("RoomForCream");
                if (RoomForCream) instructions.Add("Add cream");//if roomforcream is true, add cream
                else { instructions.Remove("Add cream"); }
                PropChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// private backing variable for decaf
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// gets and sets decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;//gets boolean value for decaf
            set
            {
                decaf = value;//sets boolean value of decaf to value
                PropChanged("Decaf");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice, roomForCream
        /// </summary>
        /// <returns>
        /// a list of special instructions for the coffee
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
            if(Decaf) // if it's decaf
                return $"{Size} Decaf Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
            else//if its normal caffinated
                return $"{Size} Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
        }
    }
}
