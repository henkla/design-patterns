using strategypattern.Enums;
using strategypattern.Interfaces;

namespace strategypattern.Colors
{
    public class WhiteColor : IColorStrategy
    {
        private Color myColor = Color.White;

        public string SayColor()
        {
            return $"My color is {myColor}.";
        }
    }
}