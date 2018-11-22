using System;

namespace FactoryPattern.Animals
{
    public class AnimalFactory
    {
        public IAnimal Get<T>() where T : class
        {
            switch (typeof(T).Name)
            {
                case "Cat":
                    return new Cat();
                case "Dog":
                    return new Dog();
                case "Spider":
                    return new Spider();

                default:
                    throw new ArgumentException($"{typeof(T).Name} is unknown!");
            }
        }
    }
}