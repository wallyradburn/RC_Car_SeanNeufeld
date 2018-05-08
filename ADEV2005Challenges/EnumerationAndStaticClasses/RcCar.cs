
using System;

namespace Challenges
{
    /// <summary>
    /// Class responsible for building an instance of an RcCar object
    /// </summary>
    public class RcCar
    {
        private string _make, _color;
        private int _batteryLife;
        //private bool _hasExtraBattery;
        bool _isOff;
        private Speed _speed;
        private int _battConsumption;        

        /// <summary>
        /// Changes the Speed of the car, while adjusting the battery according to the speed
        /// using a static class.  This property reports the amount of battery consumed, and allows
        /// the user change speeds of the car.  If the battery reaches 0, the car will shut off automatically.
        /// </summary>
        public int ChangeSpeed
        {
            get
            {
                _battConsumption = 0;

                switch (_speed)
                {
                    case Speed.Slow:
                        _battConsumption = SpeedConsumption.SLOW;
                        break;
                    case Speed.Medium:
                        _battConsumption = SpeedConsumption.MEDIUM;
                        break;
                    case Speed.Fast:
                        _battConsumption = SpeedConsumption.FAST;
                        break;
                    case Speed.HyperSpeed:
                        _battConsumption = SpeedConsumption.HYPER_SPEED;
                        break;
                    default:
                        _battConsumption = SpeedConsumption.NONE;
                        break;
                }
                
                if (_batteryLife - _battConsumption < 0)
                { _batteryLife = 0; TogglePower(); }

                else { _batteryLife -= _battConsumption; }

                return _battConsumption;
            }
            set { _battConsumption = value; }
        }

        //public RcCar(string make, string color, int batteryLife, bool isOff, bool hasExtraBattery = true)
        //{
        //    _make = make;
        //    _color = color;
        //    _batteryLife = batteryLife;
        //    _isOff = isOff;
        //    _hasExtraBattery = hasExtraBattery;
        //}

        /// <summary>
        /// Constructor method used to create an instanse of an RcCar object with all parameters.
        /// </summary>
        /// <param name="make">string data type used to represent the make of the car </param>
        /// <param name="color">string data type used to represent the color of the car</param>
        /// <param name="batteryLife">decimal value used to represent the life of the battery.</param>
        /// <param name="isOff">boolean value used to determine the vehicles power state</param>
        public RcCar(string make, string color, int batteryLife, bool isOff)
        {
            _make = make;
            _color = color;
            _batteryLife = batteryLife;
            _isOff = isOff;
        }

        /// <summary>
        /// Constructor method used to create a default instance of an RcCar object
        /// </summary>
        public RcCar()
            : this("seancago", "blue", 56,true)
        { }

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
        /// Void method used to toggle RcCar power on and off.
        /// </summary>
        public void TogglePower()
        {
            _isOff = !_isOff;
        }

        /// <summary>
        /// String representation of an instance of an RcCar Object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Make: {0}\nColor: {1}\nBattery Life: {2}\nPower: {3}\nExtra Battery: {4}",
                _make, Color.ToString(), _batteryLife, _isOff ? "Off" : "On");
        }

        ///TO BE USED WHEN I INCORPORTAE THE EXTRA BATTERY!!!!
        //public override string ToString()
        //{
        //    return String.Format("Make: {0}\nColor: {1}\nBattery Life: {2}\nPower: {3}\nExtra Battery: {4}",
        //        _make, Color.ToString(), _batteryLife, _isOff ? "Off" : "On", _hasExtraBattery ? "Yes" : "No");
        //}
    }
}