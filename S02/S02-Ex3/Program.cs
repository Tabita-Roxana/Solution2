using System;
using System.Collections.Generic;

namespace S02_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car c1 = new Car("blue", 1900, 3.5, true);
            Car c2 = new Car("red", 1500, 4, false);
            Car c3 = new Car("green", 1600, 4, true);
            Car c4 = new Car("white", 1500, 3.5, false);
            Car c5 = new Car("black", 1900, 5, false);
            Car c6 = new Car("white", 1500, 4, true);

            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            cars.Add(c5);
            cars.Add(c6);

            List<Car> Select(List<Car> cars, string color)
            {
                return cars.FindAll(car => car.Color.Equals(color));
            }

            List<Car> Select1(string color1, string color2)
            {
                return cars.FindAll(car => car.Color.Equals(color1) || car.Color.Equals(color2));
            }
            
            List<Car> Select2( double engineSize)
            {
                return cars.FindAll(car => car.EngineSize>engineSize);
            }
            
            List<Car> SelectCombine(string color, bool isManualShift)
            {
                return cars.FindAll(car => car.Color.Equals(color) && car.IsManualShift.Equals(isManualShift));
            }

            foreach (var car in SelectCombine("white", true))
            {
                Console.WriteLine(car);
            }
        }


    }
}