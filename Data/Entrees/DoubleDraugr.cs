/*
*FileName: DoubleDraugr.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object DoubleDraugr
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Double Draugr burger and creates the properties for it
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        private List<string> instructions = new List<string>();

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;

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
                PropChanged("Ketchup");
                if (!Ketchup) instructions.Add("Hold ketchup");//if ketchup is false, hold ketchup
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                bun = value;//sets bun to value
                PropChanged("Bun");
                if (!Bun) instructions.Add("Hold bun");//if bun is false hold bun
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                mustard = value;//sets mustard to value
                PropChanged("Mustard");
                if (!Mustard) instructions.Add("Hold mustard");//if mustard is false, hold mustard
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                pickle = value;//sets pickle to value
                PropChanged("Pickle");
                if (!Pickle) instructions.Add("Hold pickle");//if pickle is false, hold pickle
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                cheese = value;//sets cheese equal to value
                PropChanged("Cheese");
                if (!Cheese) instructions.Add("Hold cheese");//if cheese is false, hold cheese
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// private backing variable for tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// gets and sets tomato 
        /// </summary>
        public bool Tomato
        {
            get => tomato; //gets value of tomato
            set
            {
                tomato = value;//sets tomato equal to value
                PropChanged("Tomato");
                if (!Tomato) instructions.Add("Hold tomato");//if tomato is false, hold tomato
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// private backing variable for lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// gets and sets lettuce 
        /// </summary>
        public bool Lettuce
        {
            get => lettuce; //gets value of lettuce
            set
            {
                lettuce = value;//sets lettuce equal to value
                PropChanged("Lettuce");
                if (!Lettuce) instructions.Add("Hold lettuce");//if lettuce is false, hold lettuce
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// private backing variable for mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// gets and sets mayo 
        /// </summary>
        public bool Mayo
        {
            get => mayo; //gets value of mayo
            set
            {
                mayo = value;//sets mayo equal to value
                PropChanged("Mayo");
                if (!Mayo) instructions.Add("Hold mayo");//if mayo is false, hold mayo
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the bun, ketchup, pickle, tomato, lettuce, mayo, and mustard
        /// </summary>
        /// <returns>
        /// a list of special instructions 
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get => instructions;//return the list
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a string describing the burger
        /// </returns>
        public override string ToString()
        {
            string name =  "Double Draugr";// set return value of ToString to Double Draugr

            if (!Bun) name += "\n   - Hold bun";
            if (!Ketchup) name += "\n   - Hold ketchup";
            if (!Mustard) name += "\n   - Hold mustard";
            if (!Pickle) name += "\n   - Hold pickle";
            if (!Cheese) name += "\n   - Hold cheese";
            if (!Tomato) name += "\n   - Hold tomato";
            if (!Lettuce) name += "\n   - Hold lettuce";
            if (!Mayo) name += "\n   - Hold mayo";

            return name;
        }

        /// <summary>
        /// a string that holds the description of the object
        /// </summary>
        public override string Description
        {
            get { return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo."; }
        }

    }
}
