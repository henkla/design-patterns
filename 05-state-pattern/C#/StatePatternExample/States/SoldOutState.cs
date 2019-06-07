using System;

internal class SoldOutState : IGumballMachineState
{
    private GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense() => Console.WriteLine("There are no gumballs to dispense.");

    public void EjectCoin() => Console.WriteLine("The machine can't hold coins when out of gumballs.");

    public void InsertCoin() => Console.WriteLine("The machine won't accept coins when out of gumballs.");

    public void TurnCrank() => Console.WriteLine("Turning the crank yields no result.");
}