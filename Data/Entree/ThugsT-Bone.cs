using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Thugs T-Bone and creates the properties for it
    /// </summary
    class ThugsT_Bone
    {
        /// <summary>
        /// Gets the price of the steak
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// gets the calories of the steak
        /// </summary>
        public uint Calories => 982;

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the t-bone there are none returns empty
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";// set return value of ToString to Thugs T-Bone
        }
    }
}
