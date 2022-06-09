using System;
using System.Collections.Generic;
using System.Linq;
namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int window = int.Parse(Console.ReadLine());
            //int totalTime = greenLight + window;
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            bool crash = false;
            int passedCars = 0;
            while (input != "END")
            {
                int totalTime = greenLight + window;
                while (input != "green" )
                {
                    if ( input == "END")
                    {
                        if (crash == false)
                        {
                            Console.WriteLine($"Everyone is safe.\n{passedCars} total cars passed the crossroads.");
                        }
                        return;
                    }
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                }
                while (cars.Count > 0)
                {
                    string currCar = cars.Dequeue();
                    if (currCar.Length <= totalTime)
                    {
                        passedCars++;
                    }
                    else
                    {
                        crash = true;
                        Console.WriteLine($"A crash happened!\n{currCar} was hit at {currCar[totalTime]}.");
                        return;
                    }
                    totalTime -= currCar.Length;
                    if (totalTime <= window)
                    {
                        break;
                    }

                }



                input = Console.ReadLine();
            }
            if (crash == false)
            {
                Console.WriteLine($"Everyone is safe.\n{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
