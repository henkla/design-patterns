using strategypattern.Interfaces;

namespace strategypattern.Honks
{
    class LoudHonk : IHonkingStrategy
    {
        public string DoHonk()
        {
            return "This is a loud honk!";
        }
    }
}