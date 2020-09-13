using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A interface class for all the menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the given item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the given item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the given item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
