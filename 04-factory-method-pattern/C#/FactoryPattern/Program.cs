using FactoryPattern.Animals;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalFactory = new AnimalFactory();

            var animal = animalFactory.Get<Cat>();
            animal.SaySomething();

            animal = animalFactory.Get<Dog>();
            animal.SaySomething();

            animal = animalFactory.Get<Spider>();
            animal.SaySomething();
        }
    }
}