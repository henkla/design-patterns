using System;

namespace StatePatternExample
{
    class Program
    {
        private static GumballMachine _gumballMachine;
        static void Main(string[] args)
        {
            _gumballMachine = new GumballMachine(3);

            CountGumballsAndInsertCoinAndEjectCoin();
            
            while (_gumballMachine.NumberOfGumballs > 0) 
            {
                CountGumballsAndInsertCoinAndTurnCrank();
            }
            
            CountGumballsAndInsertCoinAndTurnCrank();
            CountGumballsAndInsertCoinAndTurnCrank();

            TiltMachineAndTryToOperate();
        }

        private static void TiltMachineAndTryToOperate()
        {
            Console.WriteLine();
            _gumballMachine.TiltMachine();
            _gumballMachine.InsertCoin();
            _gumballMachine.TurnCrank();
        }

        private static void CountGumballsAndInsertCoinAndTurnCrank() {

            Console.WriteLine();
            _gumballMachine.CountGumballs();
            _gumballMachine.InsertCoin();
            _gumballMachine.TurnCrank();
        }

        private static void CountGumballsAndInsertCoinAndEjectCoin() {

            Console.WriteLine();
            _gumballMachine.CountGumballs();
            _gumballMachine.InsertCoin();
            _gumballMachine.EjectCoin();
        }
    }
}
