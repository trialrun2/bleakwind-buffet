using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Warropr Water
    /// </summary>
    public class WarriorWater
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
        private double price = 0.00;

        /// <summary>
        /// gets price
        /// </summary>
        public double Price
        {
            get { return price; }//gets/returns price
        }

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 0;

        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories
        {
            get { return calories; }//gets/returns calories
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
        /// private backing variable for lemon
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// gets and sets lemon
        /// </summary>
        public bool Lemon
        {
            get => lemon;//gets boolean value for lemon
            set => lemon = value;//sets boolean value of lemon to value
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice, and lemon
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!Ice) instructions.Add("Hold ice");//if ice is false, hold ice
                if (Lemon) instructions.Add("Add lemon");//if lemon is true, add lemon
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
                return $"{cupSize} Warrior Water";// set return value of ToString to {cupSize} Warrior Water
        }
    }
}
