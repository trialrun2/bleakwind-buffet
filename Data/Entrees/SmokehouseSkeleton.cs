﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the smokehouse skeleton breakfast combo and creates the properties for it
    /// </summary>
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the breakfast
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// gets the calories of the breakfast
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// private backing variable for sausageLink
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// gets and sets sausageLink 
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;//gets value of sausageLink
            set
            {
                sausageLink = value;//sets sausageLink equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
            get => egg;//gets value of egg
            set
            {
                egg = value;//sets egg equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for hashBrowns
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// gets and sets hashBrowns 
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;//gets value of hashBrowns
            set
            {
                hashBrowns = value;//sets hashBrowns equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private backing variable for pancake
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// gets and sets pancake 
        /// </summary>
        public bool Pancake
        {
            get => pancake; //gets value of pancake
            set
            {
                pancake = value;//sets pancake equal to value
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the sausage, eggs, hash browns and pancakes
        /// </summary>
        /// <returns>
        /// a list of special instructions for the smokehouse skeleton
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!SausageLink) instructions.Add("Hold sausage");//if sausageLink is false, hold sausageLink
                if (!Egg) instructions.Add("Hold eggs");//if egg is false, hold egg
                if (!HashBrowns) instructions.Add("Hold hash browns");//if hashbrowns is false, hold hashbrowns
                if (!Pancake) instructions.Add("Hold pancakes");//if pancake is false, hold pancake
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
            return "Smokehouse Skeleton";// set return value of ToString to Smokehouse Skeleton
        }
    }
}
