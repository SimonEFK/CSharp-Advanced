using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carName = input[0];
                decimal fuelAmount = decimal.Parse(input[1]);
                decimal fuelConsumation = decimal.Parse(input[2]);
                Car currentCar = new Car(carName, fuelAmount, fuelConsumation);
                cars.Add(currentCar);
            }
            string action;
            while ((action = Console.ReadLine()) != "End")
            {
                string[] actionDetails = action.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carToDrive = actionDetails[1];
                decimal distance = decimal.Parse(actionDetails[2]);
                Car carToBeDriven = cars.Where(x => x.Model == carToDrive).FirstOrDefault();
                int index = cars.IndexOf(carToBeDriven);
                cars[index].Drive(distance);

            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}
