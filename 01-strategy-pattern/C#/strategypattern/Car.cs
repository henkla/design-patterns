using strategypattern.Interfaces;
using System;

namespace strategypattern
{
    public class Car
    {
        private IHonkingStrategy _honkingStrategy;
        private IColorStrategy _colorStrategy;

        public Car(IHonkingStrategy honkingStrategy, IColorStrategy colorStrategy)
        {
            _honkingStrategy = honkingStrategy;
            _colorStrategy = colorStrategy;
        }

        public void Run()
        {
            Console.WriteLine(DoTheHonk());
            Console.WriteLine(SayTheColor());
            Console.WriteLine();
        }

        private string DoTheHonk()
        {
            return _honkingStrategy.DoHonk();
        }

        private string SayTheColor()
        {
            return _colorStrategy.SayColor();
        }
    }
}