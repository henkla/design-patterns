using strategypattern.Honks;

namespace strategypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car(new LoudHonk(), new Colors.BlueColor());
            car.Run();

            car = new Car(new WhisperingHonk(), new Colors.GreenColor());
            car.Run();

            car = new Car(new RegularHonk(), new Colors.WhiteColor());
            car.Run();
        }
    }
}