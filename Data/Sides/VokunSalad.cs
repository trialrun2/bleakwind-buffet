using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// creates class with properties for Vokun Salad
    /// </summary>
    class VokunSalad
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
        private double price = 0.93;

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
                    price = 1.82;//set price equal to 1.82
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 1.28;//set price equal to 1.28
                }
                else
                {
                    price = 0.93;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 41;

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
                    calories = 73;//set calories equal to 73
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    calories = 52;//set calories equal to 52
                }
                else
                {
                    calories = 41;//set calories back to default
                }
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{sideSize} Vokun Salad";// set return value of ToString to {sideSize} Vokun Salad
        }
    }
}
