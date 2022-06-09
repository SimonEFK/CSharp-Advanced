using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tires[] tires = new Tires[4];

                int counter = 0;
                for (int j = 5; j < input.Length; j += 2)
                {
                    double tirePessure = double.Parse(input[j]);
                    int age = int.Parse(input[j + 1]);
                    tires[counter++] = new Tires(tirePessure, age);
                }
                Car currentCar = new Car(carModel, engine, cargo, tires);
                cars.Add(currentCar);
            }
            string action = Console.ReadLine();


            if (action == "fragile")
            {
                foreach (var item in cars.Where(x => x.Cargo.Type == action && x.Tires.Any(t=>t.TirePressure<1)))
                {
                    Console.WriteLine($"{item.Model}");
                }
            }
            else
            {
                foreach (var item in cars.Where(x => x.Cargo.Type == action && x.Engine.Power > 250))
                {
                    Console.WriteLine($"{item.Model}");
                }
            }


            //Engine engine = new Engine(150, 500);
            //Cargo cargo = new Cargo(150, "Fragile");
            //Tires[] tires = new Tires[4] {new Tires(1,3.5),new Tires(3,5.4),new Tires(5,3.2),new Tires(5,3.76) };            
            //Car car = new Car("bmw", engine, cargo,tires);
        }
    }
}
