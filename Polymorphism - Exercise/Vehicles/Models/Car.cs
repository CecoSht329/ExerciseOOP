
using System;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                if (value > TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return tankCapacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                tankCapacity = value;
            }
        }

        public void Drive(double distance)
        {
            if (FuelQuantity >= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForCar))
            {
                FuelQuantity -= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForCar);
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }

        }

        public void Refuel(double fuel)
        {
            if (fuel > 0)
            {
                double availableSpace = TankCapacity - FuelQuantity;
                if (fuel <= availableSpace)
                {
                    FuelQuantity += fuel;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
