using strategypattern.Interfaces;
using System;

namespace strategypattern.Honks
{
    class RegularHonk : IHonkingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("This is just a regular honk.");
        }
    }
}