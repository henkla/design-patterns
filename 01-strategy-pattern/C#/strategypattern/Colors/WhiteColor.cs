using strategypattern.Interfaces;
using System;

namespace strategypattern.Colors
{
    public class WhiteColor : IColorStrategy
    {
        public void Execute()
        {
            Console.WriteLine("My color is White.");
        }
    }
}