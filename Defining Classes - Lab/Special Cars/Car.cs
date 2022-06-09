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


        public string Make { get=>this.make; set { this.make = value; } }
        public string Model { get => this.model; set { this.model = value; } }
        public int Year { get => this.year; set { this.year = value; } }
        public double FuelQuantity { get => this.fuelQuantity; set { this.fuelQuantity = value; } }
        public double FuelConsumption { get => this.fuelConsumption; set { this.fuelConsumption = value; } }
        public Engine Engine { get => this.engine; set { this.engine = value; } }
        public Tire[] Tires { get => this.tires; set { this.tires = value; } }

        public double GetTirePressureSum()
        {
            double sum = 0;
            foreach (var item in Tires)
            {
                sum += item.Pressure;
            }
            return sum;
        }

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
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"HorsePowers: {this.engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {this.FuelQuantity}");
            return sb.ToString().Trim();
        }


    }
}
