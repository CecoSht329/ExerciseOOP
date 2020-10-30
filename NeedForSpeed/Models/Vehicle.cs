namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; private set; }
        public double Fuel { get; private set; }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        {
            double consumedFuel = kilometers * FuelConsumption;
            if (consumedFuel <= Fuel)
            {
                Fuel -= consumedFuel;
            }
        }
    }
}
