using System;

namespace StatePatternExample
{
    class Program
    {
        private static GumballMachine _gumballMachine;
        static void Main(string[] args)
        {
            _gumballMachine = new GumballMachine(3);

            CountGumballsAndÍnsertCoinAndEjectCoin();
            
            while (_gumballMachine.NumberOfGumballs > 0) 
            {
                CountGumballsAndÍnsertCoinAndTurnCrank();
            }
            
            CountGumballsAndÍnsertCoinAndTurnCrank();
            CountGumballsAndÍnsertCoinAndTurnCrank();
            CountGumballsAndÍnsertCoinAndTurnCrank();
        }

        private static void CountGumballsAndÍnsertCoinAndTurnCrank() {

            Console.WriteLine();
            _gumballMachine.CountGumballs();
            _gumballMachine.InsertCoin();
            _gumballMachine.TurnCrank();
        }

        private static void CountGumballsAndÍnsertCoinAndEjectCoin() {

            Console.WriteLine();
            _gumballMachine.CountGumballs();
            _gumballMachine.InsertCoin();
            _gumballMachine.EjectCoin();
        }
    }
}
