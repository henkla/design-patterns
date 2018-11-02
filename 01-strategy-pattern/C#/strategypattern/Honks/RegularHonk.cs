using strategypattern.Interfaces;

namespace strategypattern.Honks
{
    class RegularHonk : IHonkingStrategy
    {
        public string DoHonk()
        {
            return "This is just a regular honk.";
        }
    }
}