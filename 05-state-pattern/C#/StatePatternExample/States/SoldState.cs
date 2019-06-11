using System;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public class SoldState : BaseState
    {
        private string _name;

        public SoldState(GumballMachine gumballMachine, StateFactory stateFactory) : base(gumballMachine, stateFactory)
        {
            _name = this.GetType().Name;
        }

        public override void Dispense()
        {
            Console.WriteLine($"[{_name}] Dispensing gumball.");
            _stateFactory.SetNextState(_stateFactory.GetNoCoinState());
        }

        public override void InsertCoin() => Console.WriteLine($"[{_name}] Machine is busy.");
    }
}