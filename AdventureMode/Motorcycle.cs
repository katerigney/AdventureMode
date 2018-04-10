using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class Motorcycle : Engines, IWearHelmet
    {
        public Motorcycle()
        {
            Name = "Motorcycle";
            NumberOfWheels = 2;
        }

        public void Helmet()
        {
            Console.WriteLine("Your head is exposed when you ride a motorcycle. Please wear a helmet.");
        }
    }
}
