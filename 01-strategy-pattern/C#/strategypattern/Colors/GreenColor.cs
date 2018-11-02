using strategypattern.Enums;
using strategypattern.Interfaces;

namespace strategypattern.Colors
{
    public class GreenColor : IColorStrategy
    {
        private Color myColor = Color.Green;

        public string SayColor()
        {
            return $"My color is {myColor}.";
        }
    }
}