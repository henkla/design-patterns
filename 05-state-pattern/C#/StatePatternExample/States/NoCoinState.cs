using System;

public class NoCoinState : IGumballMachineState
{
    private GumballMachine _gumballMachine;

    public NoCoinState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense() => Console.WriteLine("Can't dispense unless crank is turned.");


    public void EjectCoin() => Console.WriteLine("Can't eject coin if not inserted.");

    public void InsertCoin()
    {
        Console.WriteLine("Coin inserted.");
        _gumballMachine.SetState(new HasCoinState(_gumballMachine));
    }

    public void TurnCrank() => Console.WriteLine("Turning crank without coin yields no result.");
}