using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class Unicycle : PedalPowered, IWearHelmet
    {
        public Unicycle()
        {
            Name = "Unicycle";
            NumberOfWheels = 1;
        }

        public void Helmet()
        {
            Console.WriteLine("Your head is exposed when you ride a unicycle. Please wear a helmet.");
        }


    }
}
