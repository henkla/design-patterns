using System;

namespace FactoryPattern.Animals
{
    internal class Cat : IAnimal
    {
        public void SaySomething()
        {
            Console.WriteLine("Mjaaaaau");
        }
    }
}