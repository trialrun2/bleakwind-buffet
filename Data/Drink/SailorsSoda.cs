using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for sailor soda, creates properties for it
    /// </summary>
    public class SailorsSoda
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
        /// private backing variable for flavor
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// gets and sets flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;//gets flavor
            set => flavor = value;//sets flavor to value
        }

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.42;

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
                    price = 2.07;//set price equal to 2.07
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.74;//set price equal to 1.74
                }
                else
                {
                    price = 1.42;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 117;

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
                    calories = 205;//set calories equal to 205
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 153;//set calories equal to 153
                }
                else
                {
                    calories = 117;//set calories back to default
                }
            }
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
                if (!Ice) instructions.Add("Hold ice");//if ice is false, hold ice
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{cupSize} {flavor} Sailor Soda";// set return value of ToString to {Size} {flavor} Sailor Soda
        }
    }
}
