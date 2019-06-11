using System;
using StatePatternExample;
using StatePatternExample.Interfaces;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public abstract class BaseState : IGumballMachineState
    {
        protected GumballMachine _gumballMachine;
        protected StateFactory _stateFactory;
        private string _name;

        public BaseState(GumballMachine gumballMachine, StateFactory stateFactory) 
        {
            _gumballMachine = gumballMachine;
            _stateFactory = stateFactory;
            _name = this.GetType().Name;
        }

        public virtual void Dispense() { return; }

        public virtual void EjectCoin() => Console.WriteLine($"[{_name}] No coin was ejected.");

        public virtual void InsertCoin() => Console.WriteLine($"[{_name}] Coin not accepted.");

        public virtual void TurnCrank() => Console.WriteLine($"[{_name}] Turning the crank yields no result.");
    }
}