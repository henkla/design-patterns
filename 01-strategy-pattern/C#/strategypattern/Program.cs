using strategypattern.Honks;
using System;

namespace strategypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car(new LoudHonk(), new Colors.BlueColor());
            car.Honk();
            car.Color();
            Console.WriteLine();

            car = new Car(new WhisperingHonk(), new Colors.GreenColor());
            car.Honk();
            car.Color();
            Console.WriteLine();

            car = new Car(new RegularHonk(), new Colors.WhiteColor());
            car.Honk();
            car.Color();
            Console.WriteLine();
        }
    }
}