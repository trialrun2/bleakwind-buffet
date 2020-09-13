using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
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
    }
}
