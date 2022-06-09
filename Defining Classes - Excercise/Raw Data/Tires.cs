using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tires
    {
        public Tires(double tirePressure, int age)
        {
            TirePressure = tirePressure;
            Age = age;
        }

        public double TirePressure { get; set; }
        public int Age { get; set; }
    }
}
