using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get => this.horsePower; set { this.horsePower = value; } }
        public double CubicCapacity { get => this.cubicCapacity; set { this.cubicCapacity = value; } }
    }
}
