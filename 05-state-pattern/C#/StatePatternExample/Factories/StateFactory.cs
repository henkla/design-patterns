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
        private GumballMachine _gumballMachine;

        public StateFactory(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public IGumballMachineState GetNoCoinState() 
        {
            if (_noCoinState == null)
                _noCoinState = new NoCoinState(_gumballMachine, this);

            return _noCoinState;
        }

        internal IGumballMachineState SetNextState(IGumballMachineState nextState)
        {
            _nextState = nextState;
            return _nextState;
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
            return GetNoCoinState();
        }
    }
}