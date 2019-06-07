using System;

namespace StatePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(2);

            gumballMachine.InsertCoin();
            gumballMachine.EjectCoin();

            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();

            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();

            // should not work since there are not enough gumballs
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();

            // should not even accept coin since state is SoldOut
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
        }
    }
}
