using strategypattern.Interfaces;
using System;

namespace strategypattern
{
    public class Car
    {
        private IHonkingStrategy _honk;
        private IColorStrategy _color;

        public Car(IHonkingStrategy honkingStrategy, IColorStrategy colorStrategy)
        {
            _honk = honkingStrategy;
            _color = colorStrategy;
        }
        
        public void Honk()
        {
            _honk.Execute();
        }

        public void Color()
        {
            _color.Execute();
        }
    }
}