/*
*FileName: PillyPoacher.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object PhillyPoacher
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Philly Poacher and creates the properties for it
    /// </summary
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the philly cheesesteak
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// gets the calories of the sandwich
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// private backing variable for sirloin
        /// </summary>
        private bool sirloin = true;

        /// <summary>
        /// gets and sets sirloin 
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;//gets value of sirloin
            set
            {
                sirloin = value;//sets sirloin equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for onion
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// gets and sets onion 
        /// </summary>
        public bool Onion
        {
            get => onion;//gets value of onion
            set
            {
                onion = value;//sets onion equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for roll
        /// </summary>
        private bool roll = true;

        /// <summary>
        /// gets and sets roll 
        /// </summary>
        public bool Roll
        {
            get => roll;//gets value of roll
            set
            {
                roll = value;//sets roll equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the sirloin onion and roll
        /// </summary>
        /// <returns>
        /// a list of special instructions for the philly poacher
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!Sirloin) instructions.Add("Hold sirloin");//if sirloin is false, hold sirloin
                if (!Onion) instructions.Add("Hold onions");//if onion is false, hold onion
                if (!Roll) instructions.Add("Hold roll");//if roll is false, hold roll
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the sandwich
        /// </returns>
        public override string ToString()
        {
            return "Philly Poacher";// set return value of ToString to Philly Poacher
        }
    }
}
