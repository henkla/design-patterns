namespace StatePatternExample.Interfaces
{
    public interface IGumballMachineState 
    {
        void InsertCoin();
        void EjectCoin();
        void TurnCrank();
        void Dispense();
    }
}