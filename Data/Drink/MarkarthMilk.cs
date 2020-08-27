using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Markarth Milk
    /// </summary>
    class MarkarthMilk
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
        private double price = 1.05;

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
                    price = 1.22;//set price equal to 1.22
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.11;//set price equal to 1.11
                }
                else
                {
                    price = 1.05;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 56;

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
                    calories = 93;//set calories equal to 93
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 72;//set calories equal to 72
                }
                else
                {
                    calories = 56;//set calories back to default
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
        /// creates list of special instructions based on the boolean values 
        /// of the ice
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (Ice) instructions.Add("Add ice");//if ice is true, add ice
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{cupSize} Markarth Milk";// set return value of ToString to {cupSize} Markarth Milk
        }
    }
}
