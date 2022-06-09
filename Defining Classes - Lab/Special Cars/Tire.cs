using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year,double pressure)
        {
            Year = year;
            Pressure = pressure;

        }
        private int year;
        private double pressure;

        public int Year { get=> this.year; set { this.year = value; }}
        public double Pressure { get=>this.pressure; set { this.pressure = value; }}

    }
}
