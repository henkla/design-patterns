using System;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public class ErrorState : BaseState
    {
        private Exception _exception;
        private string _name;

        public ErrorState(GumballMachine gumballMachine, StateFactory stateFactory, Exception exception = null) 
        : base(gumballMachine, stateFactory)
        {
            _exception = exception;
            _name = this.GetType().Name;
        }

        public override void Dispense() => Console.WriteLine($"[{_name}] Machine is unable to dispense gumballs when in error state.");

        public override void EjectCoin() => Console.WriteLine($"[{_name}] Machine is unable to hold coins when in error state.");

        public override void InsertCoin() => Console.WriteLine($"[{_name}] Machine won't accept coins when in error state.");
    }
}