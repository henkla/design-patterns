using System;
using StatePatternExample.Factories;
using StatePatternExample.Interfaces;

namespace StatePatternExample
{
    public class GumballMachine
    {
        private string _name;
        private StateFactory _stateFactory;
        private IGumballMachineState _currentState;
        public int NumberOfGumballs { get; private set; } = 0;

        public GumballMachine(int numberOfGumballs)
        {
            _name = this.GetType().Name;
            _stateFactory = new StateFactory(this);
            _currentState = _stateFactory.GetNextState();
            AddGumballs(numberOfGumballs);
        }

        private void ConsumeGumball(int numberToConsume = 1)
        {

            NumberOfGumballs = NumberOfGumballs == 0
                ? NumberOfGumballs
                : NumberOfGumballs - numberToConsume;
        }

        public void InsertCoin() 
        {
            Console.WriteLine($"[{_name}] INSERT COIN");

            try
            {
                _currentState.InsertCoin();
                _currentState = _stateFactory.GetNextState();
            }   
            catch(Exception e) 
            {
                _currentState = _stateFactory.GetErrorState(e);
            } 
        }

        public void EjectCoin() 
        {
            Console.WriteLine($"[{_name}] EJECT COIN");

            try
            {
                _currentState.EjectCoin();
                _currentState = _stateFactory.GetNextState();
            }
            catch(Exception e) 
            {
                _currentState = _stateFactory.GetErrorState(e);
            } 
        }

        public void TurnCrank() 
        {
            Console.WriteLine($"[{_name}] TURN CRANK");

            try
            {
                _currentState.TurnCrank();
                _currentState = _stateFactory.GetNextState();

                _currentState.Dispense();
                _currentState = _stateFactory.GetNextState();

                ConsumeGumball(1);
            }
            catch(Exception e) 
            {
                _currentState = _stateFactory.GetErrorState(e);
            } 
        }

        public void CountGumballs() 
        {
            Console.WriteLine($"[{_name}] There are {NumberOfGumballs} gumballs left in the machine.");
        }

        public void AddGumballs(int addedAmount) {
            
            Console.WriteLine($"[{_name}] ADD GUMBALLS");
            
            try 
            {
                if (addedAmount > 0) 
                {
                    NumberOfGumballs = NumberOfGumballs + addedAmount;
                    _currentState = _stateFactory.GetStartingState();
                }

                Console.WriteLine($"[{_name}] Added {addedAmount} gumballs.");
            }
            catch (Exception e)
            {
                _currentState = _stateFactory.GetErrorState(e);
            }
        }
    }
}