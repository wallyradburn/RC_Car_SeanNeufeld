
using System;

namespace Challenges
{
    /// <summary>
    /// Class responsible for creating an instance of the RcCar object
    /// </summary>
    public class RcCar
    {
        private string _make, _color;
        private decimal _batteryLife;
        private bool _hasExtraBattery, _isOff;

        
        /// <summary>
        /// Property used to report and change the state of the RcCar object's color
        /// </summary>
        public string Color
        {        
            get
            {
                return _color;
            }
            
            set
            {
                _color = value;
            }
        }

        /// <summary>
        /// Method used to display the RcCar's batteryLife
        /// </summary>
        /// <returns>battery life</returns>
        public decimal DisplayBatteryPower()
        {
            return _batteryLife;
        }

        /// <summary>
        /// Method used to charge the battery
        /// </summary>
        public void ChargeBattery()
        {
             _batteryLife += 50; 
        }

       /// <summary>
       /// Method used to change the power state of the object
       /// </summary>
        public void PowerOnOff()
        {
            _isOff = !_isOff;
        }

         /// <summary>
        /// Method used to put the RcCar object in motion
        /// </summary>
        public void Go()
        {
             _batteryLife -= 5; 
        }

        /// <summary>
        /// Used to create an RcCar object with optional and full paramters
        /// </summary>
        /// <param name="make">string data type used to represent the make of the car </param>
        /// <param name="color">string data type used to represent the color of the car</param>
        /// <param name="batteryLife">decimal value used to represent the life of the battery.</param>
        /// <param name="isOff">boolean value used to determine the vehicles power state</param>
        /// <param name="hasExtraBattery">boolean value used to determine if the car is equipped with an extra battery.</param>
        public RcCar(string make, string color, decimal batteryLife, bool isOff, bool hasExtraBattery = true)
        {
            _make = make;
            _color = color;
            _batteryLife = batteryLife;
            _isOff = isOff;
            _hasExtraBattery = hasExtraBattery;
        }

        /// <summary>
        /// Used to create an instance of an RcCar object with limited parameters
        /// </summary>
        /// <param name="make">string data type used to represent the make of the car </param>
        /// <param name="color">string data type used to represent the color of the car</param>
        /// <param name="batteryLife">decimal value used to represent the life of the battery.</param>
        /// <param name="isOff">boolean value used to determine the car's power state</param>
        public RcCar(string make, string color, decimal batteryLife, bool isOff)
            : this(make, color, batteryLife, isOff, false)
        { }

        /// <summary>
        /// used to create an instance of an RcCar object with its default parameters
        /// </summary>
        public RcCar()
            : this("seancago", "blue", 55, true)
        { }



        /// <summary>
        /// String representation of an instance of an RcCar object
        /// </summary>
        /// <returns>string representation</returns>
        public override string ToString()
        {
            return String.Format("Make: {0}\nColor: {1}\nBattery Life: {2}\nPower: {3}\nExtra Battery: {4}",
                _make, Color.ToString(), DisplayBatteryPower(), _isOff ? "Off" : "On", _hasExtraBattery ? "Yes" : "No");
        }
    }
}