using strategypattern.Interfaces;
using System;

namespace strategypattern.Colors
{
    class BlueColor : IColorStrategy
    {
        public void Execute()
        {
            Console.WriteLine("My color is Blue.");
        }
    }
}