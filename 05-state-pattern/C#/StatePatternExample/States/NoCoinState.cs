using System;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public class NoCoinState : BaseState
    {
        private string _name;

        public NoCoinState(GumballMachine gumballMachine, StateFactory stateFactory) : base(gumballMachine, stateFactory) 
        {
            _name = this.GetType().Name;
        }

        public override void InsertCoin()
        {
            Console.WriteLine($"[{_name}] Coin inserted.");
            _stateFactory.SetNextState(_stateFactory.GetHasCoinState());
        }
    }
}