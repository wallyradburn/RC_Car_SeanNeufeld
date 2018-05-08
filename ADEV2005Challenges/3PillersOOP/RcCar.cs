
using System;

namespace Challenges
{
    /// <summary>
    /// Class responsible for building an instance of an RcCar object
    /// </summary>
    public class RcCar : Toy
    {
        private Battery batt;   
        private Speed _speed;
        public bool HasAI { get; private set; }

        /// <summary>
        /// Used to modify and report the state of the car's color.
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Constructor method used to create an instanse of an RcCar object with all parameters.
        /// </summary>
        /// <param name="make">string data type used to represent the make of the car </param>
        /// <param name="color">string data type used to represent the color of the car</param>
        /// <param name="batteryLife">decimal value used to represent the life of the battery.</param>
        /// <param name="isOff">boolean value used to determine the vehicles power state</param>
        public RcCar(string model, bool isOff, string color, Speed speed, bool hasAI = false) 
            : base(model, isOff) 
        {
            if(color.Equals(string.Empty))
            {
                throw new ArgumentException("This value cannot be blank", "color");
            }

                      
            this.Color = color;

            _speed = speed;           
            this.HasAI = hasAI;
        }

        public Battery AddBattery(BatteryType batteryType)
        {
           

            switch (batteryType)
            {
                case BatteryType.Copper:
                    batt = new BattCopper(BatteryType.Copper, 100, 100);
                    break;
                case BatteryType.NickelCadium:
                    batt = new BattNiCa(BatteryType.NickelCadium, 200, 200);
                    break;

            }
            return batt;
        }

        /// <summary>
        /// Used to modify the batteries life depending on the speed its travelling.
        /// </summary>
        /// <param name="speed"></param>
        public void Accellerate(Speed speed)
        {
            switch (speed)
            {
                case Speed.Slow:
                    batt.CurrentLife -= SpeedConsumption.SLOW;
                    break;
                case Speed.Medium:
                    batt.CurrentLife -= SpeedConsumption.MEDIUM;
                    break;
                case Speed.Fast:
                    batt.CurrentLife -= SpeedConsumption.FAST;
                    break;
                case Speed.HyperSpeed:
                    batt.CurrentLife -= SpeedConsumption.HYPER_SPEED;
                    break;
                default:
                    batt.CurrentLife -= SpeedConsumption.NONE;
                    break;
            }
        }
        
        /// <summary>
        /// String representation of an instance of an RcCar Object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Make: {0}\nColor: {1}\nBattery Life: {2}\nPower: {3}\nExtra Battery: {4}",
                this.Model, this.Color, batt.CurrentLife, this.IsOff ? "Off" : "On");
        }
    }
}