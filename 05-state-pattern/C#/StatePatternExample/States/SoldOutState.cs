using System;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public class SoldOutState : BaseState
    {
        private string _name;

        public SoldOutState(GumballMachine gumballMachine, StateFactory stateFactory) : base(gumballMachine, stateFactory)
        {
            _name = this.GetType().Name;
        }

        public override void InsertCoin() 
        {
            Console.WriteLine($"[{_name}] Coin inserted.");
            EjectCoin();
        }

        public override void EjectCoin() => Console.WriteLine($"[{_name}] Coin ejected.");
    }
}