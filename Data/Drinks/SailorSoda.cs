/*
*FileName: SailorSoda.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object SailorSoda
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class for sailor soda, creates properties for it
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for flavor
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 1.42;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 117;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public override Size CupSize
        {
            get => cupSize;//gets cupSize
            set
            {
                cupSize = value;//sets cupSize to value
                if (cupSize == Size.Large)//if cupSize is Large
                {
                    calories = 205;//set calories equal to 205
                    price = 2.07;//set price equal to 2.07
                }
                else if (cupSize == Size.Medium)//if cupSize is Medium
                {
                    calories = 153;//set calories equal to 153
                    price = 1.74;//set price equal to 1.74
                }
                else
                {
                    calories = 117;//set calories back to default
                    price = 1.42;//set price back to default
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// gets and sets flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;//gets flavor
            set
            {
                flavor = value;//sets flavor to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
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
        /// gets and calories
        /// </summary>
        public override uint Calories
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
            set
            {
                ice = value;//sets boolean value of ice to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice
        /// </summary>
        /// <returns>
        /// a list of special instructions for the drink
        /// </returns>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// a description of the drink
        /// </returns>
        public override string ToString()
        {
            return $"{cupSize} {flavor} Sailor Soda";// set return value of ToString to {Size} {flavor} Sailor Soda
        }
    }
}
