
using System;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Car(double fuelQuantity, double fuelConsumption)
        {
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
            FuelQuantity += fuel;
        }
    }
}
