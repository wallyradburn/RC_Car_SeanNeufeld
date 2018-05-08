using System;

namespace Challenges
{
    /// <summary>
    /// Used to build an instance of a Battery object
    /// </summary>
    public abstract class Battery
    {
        /// <summary>
        /// Used to report the type of battery being used.
        /// </summary>
        public BatteryType BattType { get; private set; }
        
        /// <summary>
        /// used to report and modify the batteries current life state.
        /// </summary>
        public abstract int CurrentLife { get; set; }

        /// <summary>
        /// used to create a model of a battery object.
        /// </summary>
        /// <param name="battType">used to determine the type of battery in use.</param>
        public Battery(BatteryType battType)
        {
            this.BattType = battType;                    
        }
        
        /// <summary>
        /// used to increase the battery's current life status.
        /// </summary>
        /// <param name="battType"></param>
        public abstract void ChargeBattery();
        
        /// <summary>
        /// A string representation of an instance of a Battery object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Battery Type: {0}/nMax Batt Life: {1}/nCurrent Batt Life: {2}",
                this.BattType);
        }       
    }
}