/*
*FileName: SmokehouseSkeleton.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object SmokehouseSkeleton
*/

using System;
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
        List<string> instructions = new List<string>();//creates new list

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
                PropChanged("SausageLink");
                if (!SausageLink) instructions.Add("Hold sausage");//if sausageLink is false, hold sausageLink
                else instructions.Remove("Hold sausage");
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
            get => egg;//gets value of egg
            set
            {
                egg = value;//sets egg equal to value
                PropChanged("Egg");
                if (!Egg) instructions.Add("Hold eggs");//if egg is false, hold egg
                else instructions.Remove("Hold eggs");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                PropChanged("HashBrowns");
                if (!HashBrowns) instructions.Add("Hold hashbrowns");//if hashbrowns is false, hold hashbrowns
                else instructions.Remove("Hold hashbrowns");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
                PropChanged("Pancake");
                if (!Pancake) instructions.Add("Hold pancakes");//if pancake is false, hold pancake
                else instructions.Remove("Hold pancakes");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
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
            string name = "Smokehouse Skeleton";

            if (!SausageLink) name += "\n   - Hold sausage";
            if (!HashBrowns) name += "\n   - Hold hashbrowns";
            if (!Egg) name += "\n   - Hold eggs";
            if (!Pancake) name += "\n   - Hold pancakes";

            return name;// set return value of ToString to Smokehouse Skeleton
        }

        /// <summary>
        /// a string that holds the description of the object
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. " +
                    "Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
    }
}
