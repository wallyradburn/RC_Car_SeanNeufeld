using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges;

namespace ClassesAndObjects
{
    /// <summary>
    /// Class used to test the API funcitonality of an RcCar object
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RcCar rcFull= createRcFull();
            rcFull.Color = "Green";
            rcFull.Go();
            rcFull.DisplayBatteryPower();
            rcFull.ChargeBattery();
            rcFull.PowerOnOff();
            rcFull.Go();
            rcFull.DisplayBatteryPower();
            Console.WriteLine(rcFull.ToString());

            RcCar rcReg = createRcReg();
            rcReg.Color = "Purple";
            rcReg.Go();
            rcReg.DisplayBatteryPower();
            rcReg.ChargeBattery();
            rcReg.PowerOnOff();
            Console.WriteLine(rcReg.ToString());

            RcCar rc = new RcCar();
            rc.Color = "Orange";
            rc.Go();
            rc.DisplayBatteryPower();
            rc.ChargeBattery();
            rc.PowerOnOff();
            Console.WriteLine(rc.ToString());

            Console.ReadKey();            
        }

        /// <summary>
        /// Used to create an instance of an RcCar with alll its parameters
        /// </summary>
        /// <returns></returns>
        public static RcCar createRcFull()
        {
            RcCar rcFull;
            string model = "littleToyCarCo",
                   color = "red";
            decimal batteryLife = 200m;
            bool hasExtraBattery = true, isOff = true;
            return rcFull = new RcCar(model,color,batteryLife,isOff,hasExtraBattery);
        }

        /// <summary>
        /// used to create an instance of an RcCar object 
        /// </summary>
        /// <returns></returns>
        public static RcCar createRcReg()
        {
            RcCar rcReg;
            string model = "JavaBuster!",
                   color = "coffeeBean";
            decimal battLife = 100M;
            bool isOff = true;
            return rcReg = new RcCar(model, color, battLife, isOff);
        }

        
    }
}
