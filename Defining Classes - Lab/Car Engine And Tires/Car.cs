using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumation) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumation;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumation, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumation)
        {
            Engine = engine;
            Tires = tires;
        }
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            if (this.fuelQuantity - (distance * this.fuelConsumption / 100) > 0)
            {
                this.fuelQuantity -= distance * (fuelConsumption / 100);
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Make: {this.Model}");
            sb.AppendLine($"Make: {this.Year}");
            sb.AppendLine($"Make: {this.FuelQuantity:F2}");
            return sb.ToString().Trim();
        }


    }
}
