/*
*FileName: Entree.cs
*Author : Zane Myers
*Description : Base class for the different entrees sets up the basic properties used in each entree
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }
        
        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// public property gets the value of the toString method
        /// </summary>
        public string Name { get => ToString(); }

        /// <summary>
        /// public method to update the property shown in the wpf
        /// </summary>
        /// <param name="propName">name of the property to be updated</param>
        public void PropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// a description of the object
        /// </summary>
        public abstract string Description { get; }
    }
}
