using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int horsePower = 10;
            double fuel = 20;
            Car car = new Car(horsePower, fuel);
            Motorcycle motorcycle = new Motorcycle(horsePower, fuel);
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(horsePower, fuel);
            car.Drive(2);
            motorcycle.Drive(2);
            raceMotorcycle.Drive(2);
            Console.WriteLine(car.Fuel);
            Console.WriteLine(motorcycle.Fuel);
            Console.WriteLine(raceMotorcycle.Fuel);
        }
    }
}
