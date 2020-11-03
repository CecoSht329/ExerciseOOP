
using System;

namespace Vehicles
{
    public class Bus : IVehicle, IDriveFull
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
            if (FuelQuantity >= distance * FuelConsumption)
            {
                FuelQuantity -= distance * FuelConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveFull(double distance)
        {
            if (FuelQuantity >= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForBus))
            {
                FuelQuantity -= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForBus);
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
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
