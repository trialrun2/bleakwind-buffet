﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Thalmor Triple burger and creates the properties for it
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// gets the calories of the burger
        /// </summary>
        public uint Calories => 943;

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
            set => ketchup = value;//sets the value of ketchup to value
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
            set => bun = value;//sets value of bun to bun
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
            set => mustard = value;//sets value of mustard to value
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
            set => pickle = value; //sets value of pickle to value
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
            set => cheese = value; //sets value of cheese to value
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
            set => tomato = value; //sets value of tomato to value
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
            set => lettuce = value; //sets value of lettuce to value
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
            set => mayo = value; //sets value of mayo to value
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
            set => bacon = value; //sets value of bacon to value
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
            set => egg = value; //sets value of egg to value
        }

        /// <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the bun, ketchup, pickle, tomato, lettuce, mayo, and mustard
        /// </summary>
        /// <returns>
        /// a list of special instructions for the triple
        /// </returns>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!Bun) instructions.Add("Hold bun");//if bun is false, hold bun
                if (!Ketchup) instructions.Add("Hold ketchup");//if ketchup is false, hold ketchup
                if (!Pickle) instructions.Add("Hold pickle");//if pickle is false, hold pickle
                if (!Mustard) instructions.Add("Hold mustard");//if mustard is false, hold mustard
                if (!Cheese) instructions.Add("Hold cheese");//if cheese is false, hold cheese
                if (!Tomato) instructions.Add("Hold tomato");//if tomato is false, hold tomato
                if (!Lettuce) instructions.Add("Hold lettuce");//if lettuce is false, hold lettuce
                if (!Mayo) instructions.Add("Hold mayo");//if mayo is false, hold mayo
                if (!Bacon) instructions.Add("Hold bacon");//if bacon is false, hold bacon
                if (!Egg) instructions.Add("Hold egg");//if egg is false, hold egg
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
            return "Thalmor Triple";// set return value of ToString to Double Draugr
        }
    }
}
