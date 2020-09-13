using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// creats class and properties for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// private backing variable for sideSize
        /// </summary>
        private Size sideSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.22;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 105;

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
                    price = 1.93;//set price equal to 0.96
                    calories = 179;//set calories equal to 100
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 1.58;//set price equal to 0.76
                    calories = 142;//set calories equal to 89
                }
                else
                {
                    price = 1.22;//set price back to default
                    calories = 105;//set calories back to default
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
        /// /// <returns>
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
        /// a description of the side
        /// </returns>
        public override string ToString()
        {
            return $"{sideSize} Mad Otar Grits";// set return value of ToString to {sideSize} Mad Otar Grits
        }
    }
}
