using strategypattern.Enums;
using strategypattern.Interfaces;

namespace strategypattern.Colors
{
    class BlueColor : IColorStrategy
    {
        private Color myColor = Color.Blue;

        public string SayColor()
        {
            return $"My color is {myColor}.";
        }
    }
}