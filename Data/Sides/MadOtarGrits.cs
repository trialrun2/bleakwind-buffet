using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// creats class and properties for Mad Otar Grits
    /// </summary>
    class MadOtarGrits
    {
        /// <summary>
        /// private backing variable for sideSize
        /// </summary>
        private Size sideSize = Size.Small;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public Size SideSize
        {
            get => sideSize;//gets cupSize
            set => sideSize = value;//sets cupSize to value
        }

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.22;

        /// <summary>
        /// gets and sets price
        /// </summary>
        public double Price
        {
            get { return price; }//gets/returns price
            set
            {
                if (sideSize == Size.Large)//if sideSize is equal to Large
                {
                    price = 1.93;//set price equal to 1.93
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 1.58;//set price equal to 1.58
                }
                else
                {
                    price = 1.22;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 105;

        /// <summary>
        /// gets and sets price
        /// </summary>
        public uint Calories
        {
            get { return calories; }//gets/returns price
            set
            {
                if (sideSize == Size.Large)//if sideSize is equal to Large
                {
                    calories = 179;//set calories equal to 179
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    calories = 142;//set calories equal to 142
                }
                else
                {
                    calories = 105;//set calories back to default
                }
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{sideSize} Mad Otar Grits";// set return value of ToString to {sideSize} Mad Otar Grits
        }
    }
}
