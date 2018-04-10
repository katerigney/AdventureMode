using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var AllModes = new TranspoModes();
            if (AllModes.HaveWheels)
            {
                Console.WriteLine("Unicycles, bikes, motorcycles, cars and trucks all have wheels.");
            }

            var modes = new List<TranspoModes>();
            modes.Add(new Bike());
            modes.Add(new Unicycle());
            modes.Add(new Motorcycle());
            modes.Add(new NissanLeaf());

            foreach (var vehicle in modes)
            {
                Console.WriteLine($"{vehicle.Name}s have {vehicle.NumberOfWheels}.");
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            var helmets = new List<IWearHelmet>();
            helmets.Add(new Bike());
            helmets.Add(new Unicycle());
            helmets.Add(new Motorcycle());

            foreach (var vehicle in helmets)
            {
                vehicle.Helmet();
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            var pedals = new List<PedalPowered>();
            pedals.Add(new Bike());
            pedals.Add(new Unicycle());

            foreach (var vehicle in pedals)
            {
                vehicle.Pedal(vehicle.Name);
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            var engines = new List<Engines>();
            engines.Add(new Motorcycle());
            engines.Add(new NissanLeaf());

            foreach (var vehicle in engines)
            {
                vehicle.RunEngine(vehicle.Name);
            }


            Console.ReadLine();
        }
    }
}
