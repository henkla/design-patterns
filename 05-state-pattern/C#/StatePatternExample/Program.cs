using System;

namespace StatePatternExample
{
    class Program
    {
        private static GumballMachine _gumballMachine;
        static void Main(string[] args)
        {
            _gumballMachine = new GumballMachine(3);

            // lets try the insert and eject cycle
            CountGumballsAndInsertCoinAndEjectCoin();
            
            // should dispense as many gumballs as contained within
            while (_gumballMachine.NumberOfGumballs > 0) 
            {
                CountGumballsAndInsertCoinAndTurnCrank();
            }
            
            // should not dispense and should put in SouldOutState
            CountGumballsAndInsertCoinAndTurnCrank();
            CountGumballsAndInsertCoinAndTurnCrank();

            // should put in ErrorState and thus become inoperable
            TiltMachineAndTryToOperate();
            
            // should reset machine and make it work again
            Console.WriteLine();
            _gumballMachine.ResetMachine();
            CountGumballsAndInsertCoinAndTurnCrank();

            // should add gumballs, dispense 1 and then go to SoldOutState again
            _gumballMachine.AddGumballs(1);
            CountGumballsAndInsertCoinAndTurnCrank();
            CountGumballsAndInsertCoinAndTurnCrank();
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
