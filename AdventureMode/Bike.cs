using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class Bike : PedalPowered, IWearHelmet
    {
        public Bike()
        {
            Name = "Bicycle";
            NumberOfWheels = 2;
        }

        public void Helmet()
        {
            Console.WriteLine("Your head is exposed when you ride a bicycle. Please wear a helmet.");
        }
    }
}
