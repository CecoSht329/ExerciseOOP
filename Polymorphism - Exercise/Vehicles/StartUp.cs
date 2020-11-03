using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));


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
                else if (command.StartsWith("Refuel Bus"))
                {
                    bus.Refuel(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
                else if (command.StartsWith("DriveEmpty Bus"))
                {
                    bus.Drive(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
                else if (command.StartsWith("Drive Bus"))
                {
                    bus.DriveFull(double.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]));
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
