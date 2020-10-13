/*
*FileName: Side.cs
*Author : Zane Myers
*Description : Base class for the different sides sets up the basic properties used in each side
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public abstract Size SideSize { get; set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepeare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public string Name { get => ToString(); }

        public void PropChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
