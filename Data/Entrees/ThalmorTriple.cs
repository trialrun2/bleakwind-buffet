/*
*FileName: ThalmorTriple.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object ThalmorTriple
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Thalmor Triple burger and creates the properties for it
    /// </summary>
    public class ThalmorTriple : Entree, INotifyPropertyChanged
    {
        private List<string> instructions = new List<string>();//creates new list

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public override uint Calories => 943;

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
                ketchup = value;//sets ketchup equal to value
                PropChanged("Ketchup");
                if (!Ketchup) instructions.Add("Hold ketchup");//if ketchup is false, hold ketchup
                else instructions.Remove("Hold ketchup");
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
                bun = value;//sets bun equal to value
                PropChanged("Bun");
                if (!Bun) instructions.Add("Hold bun");//if bun is false, hold bun
                else instructions.Remove("Hold bun");
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
                mustard = value;//sets mustard equal to value
                PropChanged("Mustard");
                if (!Mustard) instructions.Add("Hold mustard");//if mustard is false, hold mustard
                else instructions.Remove("Hold mustard");
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
                pickle = value;//sets pickle equal to value
                PropChanged("Pickle");
                if (!Pickle) instructions.Add("Hold pickle");//if pickle is false, hold pickle
                else instructions.Remove("Hold pickle");
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
                else instructions.Remove("Hold cheese");
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
                else instructions.Remove("Hold tomato");
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
                else instructions.Remove("Hold lettuce");
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
                else instructions.Remove("Hold mayo");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// private backing variable for bacon
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// gets and sets bacon 
        /// </summary>
        public bool Bacon
        {
            get => bacon; //gets value of bacon
            set
            {
                bacon = value;//sets bacon equal to value
                PropChanged("Bacon");
                if (!Bacon) instructions.Add("Hold bacon");//if bacon is false, hold bacon
                else instructions.Remove("Hold bacon");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// private backing variable for egg
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// gets and sets egg 
        /// </summary>
        public bool Egg
        {
            get => egg; //gets value of egg
            set
            {
                egg = value;//sets egg equal to value
                PropChanged("Egg");
                if (!Egg) instructions.Add("Hold egg");//if egg is false, hold egg
                else instructions.Remove("Hold egg");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the bun, ketchup, pickle, tomato, lettuce, mayo, and mustard
        /// </summary>
        /// <returns>
        /// a list of special instructions for the triple
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get => instructions;
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// a description of the meal
        /// </returns>
        public override string ToString()
        {
            string name = "Thalmor Triple";// set return value of ToString to Double Draugr

            if (!Bun) name += "\n   - Hold bun";
            if (!Ketchup) name += "\n   - Hold ketchup";
            if (!Mustard) name += "\n   - Hold mustard";
            if (!Pickle) name += "\n   - Hold pickle";
            if (!Cheese) name += "\n   - Hold cheese";
            if (!Tomato) name += "\n   - Hold tomato";
            if (!Lettuce) name += "\n   - Hold lettuce";
            if (!Mayo) name += "\n   - Hold mayo";
            if (!Egg) name += "\n   - Hold egg";
            if (!Bacon) name += "\n   - Hold bacon";

            return name;
        }

        /// <summary>
        /// a string that holds the description of the object
        /// </summary>
        public override string Description
        {
            get { return "Think you are strong enough to take on the Thalmor? Inlcudes " +
                    "two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, " +
                    "pickle, cheese, tomato, lettuce, mayo, bacon, and an egg."; }
        }
    }
}
