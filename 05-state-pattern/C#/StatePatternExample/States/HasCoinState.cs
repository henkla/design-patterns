using System;
using StatePatternExample.Factories;

namespace StatePatternExample.States
{
    public class HasCoinState : BaseState
    {
        private string _name;

        public HasCoinState(GumballMachine gumballMachine, StateFactory stateFactory) : base(gumballMachine, stateFactory)
        {
            _name = this.GetType().Name;
        }

        public override void EjectCoin()
        {
            Console.WriteLine($"[{_name}] Coin ejected.");
            _stateFactory.SetNextState(_stateFactory.GetNoCoinState());
        }

        public override void InsertCoin() => Console.WriteLine($"[{_name}] Coin already inserted.");

        public override void TurnCrank()
        {
            Console.WriteLine($"[{_name}] Turning crank.");

            if (_gumballMachine.NumberOfGumballs > 0)
                _stateFactory.SetNextState(_stateFactory.GetSoldState());
            else
            {
                EjectCoin();
                _stateFactory.SetNextState(_stateFactory.GetSoldOutState());
            }
        }
    }
}