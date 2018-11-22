using System;

namespace FactoryPattern.Animals
{
    internal class Dog : IAnimal
    {
        public void SaySomething()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}