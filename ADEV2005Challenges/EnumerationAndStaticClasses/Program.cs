using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges;

namespace EnumerationAndStaticClasses
{
    class Program
    {
        //static string _make, _color;
        //static int _batteryLife;
        ////static bool _hasExtraBattery, _isOff;
        //static Speed _speed;
        //static int _battConsumption;

        static RcCar rcOne;
        //static RcCar rcTwo;

        static void Main(string[] args)
        {
            rcOne = new RcCar("Sony", "Magenta", 100, true);

            Console.WriteLine(rcOne.ToString());
            rcOne.ChangeSpeed = (int)Speed.HyperSpeed;
            Console.WriteLine(rcOne.ToString());

            Console.ReadKey();
        }

        
    }
}
