using System;
using StatePatternExample.Interfaces;
using StatePatternExample.States;

namespace StatePatternExample.Factories
{
    public class StateFactory 
    {
        private IGumballMachineState _noCoinState;
        private IGumballMachineState _hasCoinState;
        private IGumballMachineState _soldState;
        private IGumballMachineState _soldOutState;
        private IGumballMachineState _errorState;
        private IGumballMachineState _nextState;
        private IGumballMachineState _startingState;
        private GumballMachine _gumballMachine;

        public StateFactory(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
            _startingState = new ErrorState(_gumballMachine, this, new Exception("Starting state undefined."));
        }

        public StateFactory(GumballMachine gumballMachine, IGumballMachineState startingState)
        {
            _gumballMachine = gumballMachine;
            _startingState = startingState;
        }

        public IGumballMachineState GetNoCoinState() 
        {
            if (_noCoinState == null)
                _noCoinState = new NoCoinState(_gumballMachine, this);

            return _noCoinState;
        }

        internal void SetNextState(IGumballMachineState nextState)
        {
            _nextState = nextState;
        }

        internal IGumballMachineState GetNextState()
        {
            return _nextState == null
                ? GetStartingState()
                : _nextState;
        }

        public IGumballMachineState GetHasCoinState() 
        {
            if (_hasCoinState == null)
                _hasCoinState = new HasCoinState(_gumballMachine, this);

            return _hasCoinState;
        }

        public IGumballMachineState GetSoldState() 
        {
            if (_soldState == null)
                _soldState = new SoldState(_gumballMachine, this);

            return _soldState;
        }

        public IGumballMachineState GetSoldOutState() 
        {
            _soldOutState = new SoldOutState(_gumballMachine, this);
            return _soldOutState;
        }

        public IGumballMachineState GetErrorState(Exception e = null) 
        {
            _errorState = new ErrorState(_gumballMachine, this, e);
            return _errorState;
        }

        public IGumballMachineState GetStartingState()
        {
            if (_startingState == null)
                _startingState = new ErrorState(_gumballMachine, this, new Exception("Starting state undefined."));
            
            return _startingState;
        }

        public void SetStartingState(IGumballMachineState startingState)
        {
            _startingState = startingState;
        }
    }
}