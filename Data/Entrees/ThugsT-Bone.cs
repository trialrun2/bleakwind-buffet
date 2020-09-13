using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Thugs T-Bone and creates the properties for it
    /// </summary
    public class ThugsT_Bone : Entree
    {
        /// <summary>
        /// Gets the price of the steak
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// gets the calories of the steak
        /// </summary>
        public override uint Calories => 982;

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the t-bone there are none returns empty
        /// </summary>
        /// <returns>
        /// a list of special instruction for the meal
        /// </returns>
        public override List<string> SpecialInstructions
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
        /// <returns>
        /// a description of the meal
        /// </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";// set return value of ToString to Thugs T-Bone
        }
    }
}
