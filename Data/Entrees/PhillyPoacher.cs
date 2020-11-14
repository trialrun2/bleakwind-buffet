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
        private List<string> instructions = new List<string>();

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
                PropChanged("Sirloin");
                if (!Sirloin) instructions.Add("Hold sirloin");//if sirloin is false, hold sirloin
                else instructions.Remove("Hold sirloin");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                PropChanged("Onion");
                if (!Onion) instructions.Add("Hold onions");//if onion is false, hold onion
                else instructions.Remove("Hold onions");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                PropChanged("Roll");
                if (!Roll) instructions.Add("Hold roll");//if roll is false, hold roll
                else instructions.Remove("Hold roll");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
            get => instructions;//return the list
            
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the sandwich
        /// </returns>
        public override string ToString()
        {
            string name = "Philly Poacher";

            if (!Sirloin) name += "\n   - Hold sirloin";
            if (!Onion) name += "\n   - Hold onion";
            if (!Roll) name += "\n   - Hold roll";

            return name;
        }

        /// <summary>
        /// a string that holds the description of the object
        /// </summary>
        public override string Description
        {
            get
            {
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
            }
        }
    }
}
