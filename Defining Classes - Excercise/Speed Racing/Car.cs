using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public Car(string model, decimal fuelAmout, decimal fuelConsumationPerKilometer)
        {

            Model = model;
            if (fuelAmout < 0)
            {
                FuelAmount = 0;
            }
            else
            {
                FuelAmount = fuelAmout;

            }
            if (fuelConsumationPerKilometer < 0)
            {
                FuelConsumptionPerKilometer = 0;
            }
            else
            {

                FuelConsumptionPerKilometer = fuelConsumationPerKilometer;
            }
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumptionPerKilometer { get; set; }
        public decimal TravelledDistance { get; set; }

        public void Drive(decimal distance)
        {
            decimal fuelToBeConsumed = this.FuelConsumptionPerKilometer * distance;
            if (fuelToBeConsumed <= FuelAmount)
            {
                FuelAmount -= fuelToBeConsumed;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }

        }
    }
}
