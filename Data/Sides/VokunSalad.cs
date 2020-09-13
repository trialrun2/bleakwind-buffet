using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// creates class with properties for Vokun Salad
    /// </summary>
    public class VokunSalad : Side
    {
        /// <summary>
        /// private backing variable for sideSize
        /// </summary>
        private Size sideSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 0.93;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 41;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public override Size SideSize
        {
            get => sideSize;//gets cupSize
            set
            {
                sideSize = value;//sets cupSize to value
                if (sideSize == Size.Large)//if sideSize is equal to Large
                {
                    price = 1.82;//set price equal to 0.96
                    calories = 73;//set calories equal to 100
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 1.28;//set price equal to 0.76
                    calories = 52;//set calories equal to 89
                }
                else
                {
                    price = 0.93;//set price back to default
                    calories = 41;//set calories back to default
                }
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
        /// gets and sets price
        /// </summary>
        public override uint Calories
        {
            get { return calories; }//gets/returns price
        }

        /// <summary>
        /// creates list of special instructions should always return empty
        /// </summary>
        /// <returns>
        /// a list of special instructions for side
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                return instructions;
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a dexcription of the side
        /// </returns>
        public override string ToString()
        {
            return $"{sideSize} Vokun Salad";// set return value of ToString to {sideSize} Vokun Salad
        }
    }
}
