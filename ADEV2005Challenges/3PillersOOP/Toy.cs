using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    namespace Challenges
    {
        /// <summary>
        /// Class responsible for building an instance of a Toy object
        /// </summary>
        public class Toy
        {
            public string Model { get; private set; }                        
            public bool IsOff { get; set; }               

            /// <summary>
            /// Constructor method used to create an instanse of an RcCar object with all parameters.
            /// </summary>
            /// <param name="make">string data type used to represent the make of the car </param>            
            /// <param name="isOff">boolean value used to determine the vehicles power state</param>
            public Toy(string model, bool isOff)
            {
                if(model.Equals(string.Empty))
                {
                    throw new ArgumentException("This value cannot be blank.","model");
                }

                if(!isOff)
                {
                    throw new ArgumentException("The value must be false when initializing the objects state.","isOff");
                }
         
                this.Model = model;                
                this.IsOff = isOff;
            }                

            /// <summary>
            /// Void method used to toggle RcCar power on and off.
            /// </summary>
            public void TogglePower()
            {
                this.IsOff = !this.IsOff;
            }
        }
    }
