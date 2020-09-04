using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Garden Orc Omelette and creates the properties for it
    /// </summary>
    public class GardenOrcOmelette
    {

        /// <summary>
        /// Gets the price of the omelet
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// gets the calories of the omelet
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// private backing variable for broccoli
        /// </summary>
        private bool broccoli = true;

        /// <summary>
        /// gets and sets broccoli 
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;//gets value of broccoli
            set => broccoli = value;//sets the value of broccoli to value
        }

        /// <summary>
        /// private backing variable for mushrooms
        /// </summary>
        private bool mushrooms = true;

        /// <summary>
        /// gets and sets mushrooms 
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;//gets value of mushrooms
            set => mushrooms = value;//sets value of mushrooms to value
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
            get => tomato;//gets value of tomato
            set => tomato = value;//sets value of tomato to value
        }

        /// <summary>
        /// private backing variable for cheddar
        /// </summary>
        private bool cheddar = true;

        /// <summary>
        /// gets and sets cheddar 
        /// </summary>
        public bool Cheddar
        {
            get => cheddar; //gets value of cheddar
            set => cheddar = value; //sets value of cheddar to value
        }

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the broccoli, mushrooms, tomatoes, and cheddar
        /// </summary>
        public List<string> SpecialInstuctions
        {
            get
            {
                List<string> instructions = new List<string>();//creates new list
                if (!Broccoli) instructions.Add("Hold broccoli");//if broccoli is false, hold broccoli
                if (!Mushrooms) instructions.Add("Hold mushrooms");//if mushrooms is false, hold mushrooms
                if (!Tomato) instructions.Add("Hold tomato");//if tomato is false, hold tomato
                if (!Cheddar) instructions.Add("Hold cheddar");//if cheddar is false, hold cheddar
                return instructions;//return the list
            }
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";// set return value of ToString to Garden Orc Omelette
        }
    }
}
