﻿/*
*FileName: Drink.cs
*Author : Zane Myers
*Description : Base class for the different drinks sets up the basic properties used in each drink
*/

using System;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// a description of the object
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Public method Name returns the string from the toString method
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// public method property changed lets the program know a property has changed
        /// </summary>
        /// <param name="propName">property name for the desired property</param>
        public void PropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
