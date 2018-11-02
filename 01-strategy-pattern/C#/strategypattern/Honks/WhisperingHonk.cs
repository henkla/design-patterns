using strategypattern.Interfaces;
using System;

namespace strategypattern.Honks
{
    class WhisperingHonk : IHonkingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("This is a whispering honk...");
        }
    }
}