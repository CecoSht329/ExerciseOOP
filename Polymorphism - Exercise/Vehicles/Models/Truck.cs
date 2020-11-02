
using System;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Truck(double fuelQuantity, double fuelConsumption)
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
            if (FuelQuantity >= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForTruck))
            {
                FuelQuantity -= distance * (FuelConsumption + CommonValues.ConsumptionIncreaseForTruck);
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }

        }

        public void Refuel(double fuel)
        {
            FuelQuantity += (fuel * 0.95);
        }
    }
}
