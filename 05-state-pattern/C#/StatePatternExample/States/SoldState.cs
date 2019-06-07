using System;

internal class SoldState : IGumballMachineState
{
    private GumballMachine _gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense()
    {
        Console.WriteLine("Dispensing gumball.");
        _gumballMachine.SubtractGumball();
        _gumballMachine.SetState(new NoCoinState(_gumballMachine));
    }

    public void EjectCoin() => Console.WriteLine("Coin has already been consumed.");

    public void InsertCoin() => Console.WriteLine("Machine not ready for coin insertion yet.");

    public void TurnCrank() => Console.WriteLine("Turning the crank yields no results.");
}