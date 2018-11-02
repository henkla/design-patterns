using strategypattern.Interfaces;

namespace strategypattern.Honks
{
    class WhisperingHonk : IHonkingStrategy
    {
        public string DoHonk()
        {
            return "This is a whispering honk...";
        }
    }
}