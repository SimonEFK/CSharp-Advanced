using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            List<Car> cars = new List<Car>();
            List<Tire[]> setOfTires = new List<Tire[]>();
            List<Engine> egnineList = new List<Engine>();
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int i = 0; i < tiresInfo.Length; i += 2)
                {
                    int tireYear = int.Parse(tiresInfo[i]);
                    double tirePressure = double.Parse(tiresInfo[i + 1]);
                    tires[counter++] = new Tire(tireYear, tirePressure);
                }
                setOfTires.Add(tires);
            }
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engines = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(engines[0]);
                double cubicCapacity = double.Parse(engines[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                egnineList.Add(engine);
            }
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carDetails = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carMake = carDetails[0];
                string carModel = carDetails[1];
                int carYear = int.Parse(carDetails[2]);
                double carFuelQuantity = double.Parse(carDetails[3]);

                double carFuelConsumation = double.Parse(carDetails[4]);

                int engineIndex = int.Parse(carDetails[5]);
                int tiresIndex = int.Parse(carDetails[6]);
                cars.Add(new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumation, egnineList[engineIndex], setOfTires[tiresIndex]));
            }
            foreach (var item in cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330))
            {
                double currentCarTirePressureSum = item.GetTirePressureSum();
                if (currentCarTirePressureSum>=9&&currentCarTirePressureSum<=10)
                {
                    item.Drive(20);
                    Console.WriteLine(item.WhoAmI());
                }
            }
        }
    }
}
