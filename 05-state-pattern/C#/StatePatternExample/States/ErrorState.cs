using System;

public class ErrorState : IGumballMachineState
{
    private GumballMachine _gumballMachine;
    private Exception _exception;

    public ErrorState(GumballMachine gumballMachine, Exception exception = null)
    {
        _gumballMachine = gumballMachine;
        _exception = exception;
    }

    public void Dispense() => Console.WriteLine("Machine is unable to dispense gumballs when in error state.");

    public void EjectCoin() => Console.WriteLine("Machine is unable to hold coins when in error state.");

    public void InsertCoin() => Console.WriteLine("Machine won't accept coins when in error state.");

    public void TurnCrank() => Console.WriteLine("Turning the crank yields no result.");
}