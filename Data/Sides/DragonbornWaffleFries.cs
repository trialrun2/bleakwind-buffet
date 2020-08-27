using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// creates class and properties for Dragonborn Waffle Fries
    /// </summary>
    class DragonbornWaffleFries
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
        private double price = 0.42;

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
                    price = 0.96;//set price equal to 0.96
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 0.76;//set price equal to 0.76
                }
                else
                {
                    price = 0.42;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 77;

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
                    calories = 100;//set calories equal to 100
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    calories = 89;//set calories equal to 89
                }
                else
                {
                    calories = 77;//set calories back to default
                }
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{sideSize} Dragonborn Waffle Fries";// set return value of ToString to {sideSize} Dragonborn Waffle Fries
        }
    }
}
