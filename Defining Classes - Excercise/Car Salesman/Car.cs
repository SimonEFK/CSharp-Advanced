using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = -1;
            Color = "-1";
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public string PrintCarInformation()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            if (this.Engine.Displacement == -1)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }
            if (this.Engine.Efficency == "-1")
            {
                sb.AppendLine($"    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {this.Engine.Efficency}");
            }
            if (this.Weight == -1)
            {
                sb.AppendLine($"  Weight: n/a");

            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            if (this.Color=="-1")
            {
                sb.AppendLine($"  Color: n/a");
            }
            else
            {
                sb.AppendLine($"  Color: {this.Color}");
            }
            return sb.ToString();
        }

    }

}
