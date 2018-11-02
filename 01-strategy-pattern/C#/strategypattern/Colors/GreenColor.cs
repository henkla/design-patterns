using strategypattern.Interfaces;
using System;

namespace strategypattern.Colors
{
    public class GreenColor : IColorStrategy
    {
        public void Execute()
        {
            Console.WriteLine("My color is Green.");
        }
    }
}