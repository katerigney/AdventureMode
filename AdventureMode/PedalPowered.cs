using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class PedalPowered : TranspoModes
    {
        public void Pedal(string name)
        {
            Console.WriteLine($"You ride a {name} by pedaling.");
        }
    }
}
