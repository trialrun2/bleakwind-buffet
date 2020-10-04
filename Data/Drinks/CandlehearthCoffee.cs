using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// creates class and properties for Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private backing variable for cupSize
        /// </summary>
        private Size cupSize = Size.Small;

        /// <summary>
        /// private backing variable for price
        /// </summary>
        private double price = 0.75;

        /// <summary>
        /// private backing variable for calories
        /// </summary>
        private uint calories = 7;

        /// <summary>
        /// gets and sets cupSize
        /// </summary>
        public override Size CupSize
        {
            get => cupSize;//gets cupSize
            set
            {
                cupSize = value;//sets cupSize to value
                if (cupSize == Size.Large)//if cupSize is equal to Large
                {
                    price = 1.75;//set price equal to 1.75
                    calories = 20;//set calories equal to 20
                }
                else if (cupSize == Size.Medium)//if cupSize is equal to medium
                {
                    price = 1.25;//set price equal to 1.25
                    calories = 10;//set calories equal to 10
                }
                else
                {
                    price = 0.75;//set price back to default
                    calories = 7;//set calories back to default
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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
        /// gets and sats calories
        /// </summary>
        public override uint Calories
        {
            get { return calories; }//gets/returns calories
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
            set
            {
                ice = value;//sets boolean value of ice to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for roomForCream
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// gets and sets roomForCream
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;//gets boolean value for roomForCream
            set
            {
                roomForCream = value;//sets boolean value of roomForCream to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for decaf
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// gets and sets decaf
        /// </summary>
        public bool Decaf
        {
            get => decaf;//gets boolean value for decaf
            set
            {
                decaf = value;//sets boolean value of decaf to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the ice, roomForCream
        /// </summary>
        /// <returns>
        /// a list of special instructions for the coffee
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (Ice) instructions.Add("Add ice");//if ice is true, add ice
                if (RoomForCream) instructions.Add("Add cream");//if roomforcream is true, add cream
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the meal
        /// </returns>
        public override string ToString()
        {
            if(Decaf) // if it's decaf
                return $"{cupSize} Decaf Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
            else//if its normal caffinated
                return $"{cupSize} Candlehearth Coffee";// set return value of ToString to {cupSize} Decaf Candlehearth Coffee
        }
    }
}
