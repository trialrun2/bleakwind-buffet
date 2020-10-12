/*
*FileName: BriarheartBurger.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object BriarheartBurger
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the briarheart burger creates the properties for it
    /// </summary>
    public class BriarheartBurger : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories => 743;

        /// <summary>
        /// private backing variable for ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// gets and sets ketchup 
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;//gets value of ketchup
            set
            {
                ketchup = value;//sets the value of ketchup to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }

        }

        /// <summary>
        /// private backing variable for bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// gets and sets bun 
        /// </summary>
        public bool Bun
        {
            get => bun;//gets value of bun
            set
            {
                bun = value;//sets value of bun to bun
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// gets and sets mustard 
        /// </summary>
        public bool Mustard
        {
            get => mustard;//gets value of mustard
            set
            {
                mustard = value;//sets value of mustard to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// gets and sets pickle 
        /// </summary>
        public bool Pickle
        {
            get => pickle; //gets value of pickle
            set
            {
                pickle = value; //sets value of pickle to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// gets and sets cheese 
        /// </summary>
        public bool Cheese
        {
            get => cheese; //gets value of cheese
            set
            {
                cheese = value; //sets value of cheese to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the bun, ketchup, pickle, and mustard
        /// </summary>
        /// <returns>
        /// a list of special instructions
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!Bun) instructions.Add("Hold bun");//if bun is false, hold bun
                if (!Ketchup) instructions.Add("Hold ketchup");//if ketchup is false,, hold ketchup
                if (!Pickle) instructions.Add("Hold pickle");//if pickle is false, hold pickle
                if (!Mustard) instructions.Add("Hold mustard");//if mustard is false, hold mustard
                if (!Cheese) instructions.Add("Hold cheese");//if cheese is false, hold cheese
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a string describing the burger
        /// </returns>
        public override string ToString()
        {
            return "Briarheart Burger";// set return value of ToString to Briarheart Burger
        }
    }
}
