using strategypattern.Interfaces;
using System;

namespace strategypattern.Honks
{
    class LoudHonk : IHonkingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("This is a loud honk!");
        }
    }
}