using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class Engines : TranspoModes
    {
        public virtual void RunEngine(string name)
        {
            Console.WriteLine($"A {name} uses gas to run its engine.");
        }
    }
}