using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficency = "-1";
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {            
            Displacement = displacement;
            Efficency = "-1";
        }
        public Engine(string model, int power, string efficency):this(model,power)
        {                        
            Efficency = efficency;
        }

        public Engine(string model, int power, int displacement, string efficency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficency = efficency;
        }

        public string Model { get; set; }
        public int Power { get; set; }

        public int Displacement { get; set; }
        public string Efficency { get; set; }
    }
}
