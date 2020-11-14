/*
*FileName: GardenOrcOmelette.cs
*Author : Zane Myers
*Description : Class for defining the properties of and creating the object GardenOrcOmelette
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class for the Garden Orc Omelette and creates the properties for it
    /// </summary>
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        private List<string> instructions = new List<string>();
        /// <summary>
        /// Gets the price of the omelet
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// gets the calories of the omelet
        /// </summary>
        public override uint Calories => 404;

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
            set
            {
                broccoli = value;//sets broccoli equal to value
                PropChanged("Broccoli");
                if (!Broccoli) instructions.Add("Hold broccoli");//if broccoli is false, hold broccoli
                else instructions.Remove("Hold broccoli");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
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
            set
            {
                mushrooms = value;//sets mushrooms equal to value
                PropChanged("Mushrooms");
                if (!Mushrooms) instructions.Add("Hold mushrooms");//if mushrooms is false, hold mushrooms
                else instructions.Remove("Hold mushrooms");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
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
            set
            {
                tomato = value;//sets tomato equal to value
                PropChanged("Tomato");
                if (!Tomato) instructions.Add("Hold tomato");//if tomato is false, hold tomato
                else instructions.Remove("Hold tomato");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
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
            set
            {
                cheddar = value;//sets cheddar equal to value
                PropChanged("Cheddar");
                if (!Cheddar) instructions.Add("Hold cheddar");//if cheddar is false, hold cheddar
                else instructions.Remove("Hold cheddar");
                PropChanged("SpecialInstructions");
                PropChanged("Name");
            }
        }

        // <summary>
        /// creates list of special instructions based on the boolean values 
        /// of the broccoli, mushrooms, tomatoes, and cheddar
        /// </summary>
        /// <returns> 
        /// a list of special instructions
        /// </returns>
        public override List<string> SpecialInstructions
        {
            get => instructions;//return the list
        }

        /// <summary>
        /// override ToString return value
        /// </summary>
        /// <returns>
        /// returns a description of the omelette
        /// </returns>
        public override string ToString()
        {
            string name = "Garden Orc Omelette";

            if (!Broccoli) name += "\n   - Hold broccoli";
            if (!Mushrooms) name += "\n   - Hold mushrooms";
            if (!Tomato) name += "\n   - Hold tomato";
            if (!Cheddar) name += "\n   - Hold cheddar";

            return name;
        }

        /// <summary>
        /// a string that holds the description of the object
        /// </summary>
        public override string Description
        {
            get
            {
                return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            }
        }
    }
}
