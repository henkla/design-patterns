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
            _stateFactory.SetStartingState(_stateFactory.GetNoCoinState());
            LoadNextState();
            AddGumballs(numberOfGumballs);
        }

        public void ResetMachine() 
        {
            Console.WriteLine($"[{_name}] RESET MACHINE");

            try
            {
                _stateFactory.SetNextState(_stateFactory.GetStartingState());
            }
            catch (Exception e)
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
            }
        }

        private void ConsumeGumball(int numberToConsume = 1)
        {
            NumberOfGumballs = NumberOfGumballs == 0
                ? NumberOfGumballs
                : NumberOfGumballs - numberToConsume;
        }

        public void TiltMachine()
        {
            Console.WriteLine($"[{_name}] TILT MACHINE");
            
            try 
            {
                throw new InvalidOperationException();
            }
            catch (Exception e)
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
            }
        }
        public void InsertCoin() 
        {
            Console.WriteLine($"[{_name}] INSERT COIN");

            try
            {
                LoadNextState();
                _currentState.InsertCoin();
            }   
            catch(Exception e) 
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
            } 
        }

        public void EjectCoin() 
        {
            Console.WriteLine($"[{_name}] EJECT COIN");

            try
            {
                LoadNextState();
                _currentState.EjectCoin();
            }
            catch(Exception e) 
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
            }
        }

        public void TurnCrank() 
        {
            Console.WriteLine($"[{_name}] TURN CRANK");

            try
            {
                LoadNextState();
                _currentState.TurnCrank();

                LoadNextState();
                _currentState.Dispense();

                ConsumeGumball(1);
            }
            catch(Exception e) 
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
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
                    _stateFactory.SetNextState(_stateFactory.GetStartingState());
                }

                Console.WriteLine($"[{_name}] Added {addedAmount} gumballs.");
            }
            catch (Exception e)
            {
                _stateFactory.SetNextState(_stateFactory.GetErrorState(e));
            }
        }

        private void LoadNextState() 
        {
            _currentState = _stateFactory.GetNextState();
        }
    }
}