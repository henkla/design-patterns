using System;

public class HasCoinState : IGumballMachineState
{
    private GumballMachine _gumballMachine;

    public HasCoinState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void Dispense() => Console.WriteLine("Can't dispense unless crank is turned.");

    public void EjectCoin()
    {
        Console.WriteLine("Ejecting coin.");
        _gumballMachine.SetState(new NoCoinState(_gumballMachine));
    }

    public void InsertCoin() => Console.WriteLine("Coin already inserted.");

    public void TurnCrank()
    {
        Console.WriteLine("Turning crank.");

        if (_gumballMachine.NumberOfGumballs > 0)
            _gumballMachine.SetState(new SoldState(_gumballMachine));
        else
        {
            Console.WriteLine("Out of gumballs.");
            EjectCoin();
            _gumballMachine.SetState(new SoldOutState(_gumballMachine));
        }
    }
}