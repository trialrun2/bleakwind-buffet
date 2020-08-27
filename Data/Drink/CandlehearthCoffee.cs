﻿using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Candlehearth Coffee
    /// </summary>
    class CandlehearthCoffee
    {
        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public Size CupSize
        {
            get => cupSize;//gets cupSize
            set => cupSize = value;//sets cupSize to value
        }

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 0.75;

        /// <summary>
        /// gets and sets price
        /// </summary>
        public double Price
        {
            get { return price; }//gets/returns price
            set
            {
                if (cupSize == Size.Large)//if cupSize is equal to Large
                {
                    price = 1.75;//set price equal to 1.75
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.25;//set price equal to 1.25
                }
                else
                {
                    price = 0.75;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 7;

        /// <summary>
        /// gets and sats calories
        /// </summary>
        public uint Calories
        {
            get { return calories; }//gets/returns calories
            set
            {
                if (cupSize == Size.Large)//if cupSize is Large
                {
                    calories = 20;//set calories equal to 20
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 10;//set calories equal to 10
                }
                else
                {
                    calories = 7;//set calories back to default
                }
            }
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
            set => ice = value;//sets boolean value of ice to value
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
            set => roomForCream = value;//sets boolean value of roomForCream to value
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
            set => decaf = value;//sets boolean value of decaf to value
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice, roomForCream
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (Ice) instructions.Add("Add ice");//if ice is true, add ice
                if (RoomForCream) instructions.Add("Add cream");//if roomforcream is true, add cream
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Decaf) // if it's decaf
                return $"{cupSize} Decaf Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
            else//if its normal caffinated
                return $"{cupSize} Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
        }
    }
}