using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            RcCar car = new RcCar("sean", true, "brown", Speed.Fast, true);
            car.TogglePower();
            car.Accellerate(Speed.HyperSpeed);

        }
    }
}
