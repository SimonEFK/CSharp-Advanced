using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    class Parking
    {
        public Parking(int capacity)
        {
            this.cars = new Dictionary<string, Car>();
            this.capacity = capacity;
        }
        private Dictionary<string, Car> cars;
        private int capacity;

        

        public int Count { get => this.cars.Count; set { Count = value; } }
        public string AddCar(Car car)
        {
            //if (Cars.ContainsKey(car.RegistrationNumber) == false)
            //{
            //    Cars.Add(car.RegistrationNumber.ToString(), new Car(car.Make, car.Model, car.HorsePower, car.RegistrationNumber));
            //}

            if (this.cars.ContainsKey(car.RegistrationNumber) == true)
            {
                return $"Car with that registration number, already exists!";

            }
            if (this.cars.Count >= this.capacity)
            {
                return $"Parking is full!";
            }

            this.cars[car.RegistrationNumber] = car;
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";


        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.ContainsKey(registrationNumber) == false)
            {
                return $"Car with that registration number, doesn't exist!";

            }
            else
            {
                this.cars.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string RegistrationNumber)
        {
            return this.cars.FirstOrDefault(x => x.Key == RegistrationNumber).Value;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var item in RegistrationNumbers)
            {
                this.cars.Remove(item);
            }
        }

    }
}
