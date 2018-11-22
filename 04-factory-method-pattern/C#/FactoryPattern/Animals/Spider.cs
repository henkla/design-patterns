using System;

namespace FactoryPattern.Animals
{
    internal class Spider : IAnimal
    {
        public void SaySomething()
        {
            Console.WriteLine("*prassel prassel*");
        }
    }
}