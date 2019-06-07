using System;

public class GumballMachine
{
    private IGumballMachineState _currentState;
    public int NumberOfGumballs { get; private set; }

    public GumballMachine(int numberOfGumballs)
    {
        NumberOfGumballs = numberOfGumballs;
        _currentState = new NoCoinState(this);
    }

    internal void SubtractGumball()
    {
        NumberOfGumballs--;
    }

    internal void SetState(IGumballMachineState nextState)
    {
        _currentState = nextState;
    }

    private void IdentifyCurrentState() 
    {
        Console.WriteLine($"Current state is {_currentState.GetType().Name}.");
    }

    public void InsertCoin() 
    {
        try
        {
            _currentState.InsertCoin();
        }   
        catch(Exception e) 
        {
            _currentState = new ErrorState(this, e);
        } 
    }

    public void EjectCoin() 
    {
        try
        {
            _currentState.EjectCoin();
        }
        catch(Exception e) 
        {
            _currentState = new ErrorState(this, e);
        } 
    }

    public void TurnCrank() 
    {
        try
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }
        catch(Exception e) 
        {
            _currentState = new ErrorState(this, e);
        } 
    }

    public void CountGumballs() 
    {
        Console.WriteLine($"There are {NumberOfGumballs} gumballs left in the machine.");
    }
}