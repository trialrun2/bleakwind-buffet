using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Aretino Apple Juice
    /// </summary>
    class AretinoAppleJuice
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
        private double price = 0.62;

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
                    price = 1.01;//set price equal to 1.01
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 0.87;//set price equal to 0.87
                }
                else
                {
                    price = 0.62;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 44;

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
                    calories = 132;//set calories equal to 132
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 88;//set calories equal to 88
                }
                else
                {
                    calories = 44;//set calories back to default
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
            return $"{cupSize} Aretino Apple Juice";// set return value of ToString to {cupSize} Markarth Milk
        }
    }
}
