using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string engineModel = input[0];
                int enginePower = int.Parse(input[1]);
                if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficency = input[3];
                    engines.Add(new Engine(engineModel, enginePower, displacement, efficency));
                }
                else if (input.Length == 3)
                {
                    string element = input[2];
                    if (char.IsLetter(element[0]))
                    {
                        string efficency = element;
                        engines.Add(new Engine(engineModel, enginePower, efficency));
                    }
                    else
                    {
                        int displacement = int.Parse(element);
                        engines.Add(new Engine(engineModel, enginePower, displacement));
                    }

                }
                else
                {
                    engines.Add(new Engine(engineModel, enginePower));
                }
            }
            count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = input[0];
                string engineModel = input[1];

                var engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();
                var engineIndex = engines.IndexOf(engine);

                if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];


                    Car car = new Car(carModel, engines[engineIndex], weight, color);
                    cars.Add(car);
                }
                else if (input.Length == 3)
                {
                    string element = input[2];
                    if (char.IsLetter(element[0]))
                    {
                        string color = element;
                        Car car = new Car(carModel, engines[engineIndex], color);
                        cars.Add(car);
                    }
                    else
                    {
                        int weight = int.Parse(element);
                        Car car = new Car(carModel, engines[engineIndex], weight);
                        cars.Add(car);
                    }
                }
                else
                {
                    Car car = new Car(carModel, engines[engineIndex]);
                    cars.Add(car);
                }
                
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.PrintCarInformation().Trim());
            }
        }
    }
}
