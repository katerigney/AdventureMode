using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class NissanLeaf : Engines
    {
        public NissanLeaf()
        {
            Name = "Nissan Leaf";
        }

        public override void RunEngine(string name)
        {
            Console.WriteLine($"A {name} uses electric to run its engine.");

        }
    }
}


