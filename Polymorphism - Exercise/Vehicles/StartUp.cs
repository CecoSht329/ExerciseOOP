using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            var truckInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine();
                if (command.StartsWith("Drive Car"))
                {
                    car.Drive(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
                else if (command.StartsWith("Drive Truck"))
                {
                    truck.Drive(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
                else if (command.StartsWith("Refuel Car"))
                {
                    car.Refuel(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
                else if (command.StartsWith("Refuel Truck"))
                {
                    truck.Refuel(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
