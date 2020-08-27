using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// creates class with properties for Fried Miraak
    /// </summary>
    class FriedMiraak
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
        private double price = 1.78;

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
                    price = 2.88;//set price equal to 2.88
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    price = 2.01;//set price equal to 2.01
                }
                else
                {
                    price = 1.78;//set price back to default
                }
            }
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 151;

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
                    calories = 306;//set calories equal to 306
                }
                else if (sideSize == Size.Medium)//if sideSize is equal to medium
                {
                    calories = 236;//set calories equal to 236
                }
                else
                {
                    calories = 151;//set calories back to default
                }
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{sideSize} Fried Miraak";// set return value of ToString to {sideSize} Fried Miraak
        }
    }
}
