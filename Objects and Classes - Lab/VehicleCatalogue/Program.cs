using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split("/");
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int horsePowerOrWeight = int.Parse(tokens[3]);
                if (type == "Car")
                {
                    Car currentCar = new Car(brand, model, horsePowerOrWeight);
                    cars.Add(currentCar);
                }
                else
                {
                    Truck currentTruck = new Truck(brand, model, horsePowerOrWeight);
                    trucks.Add(currentTruck);
                }



            }
                CatalogueVehicle catalogue = new CatalogueVehicle(cars, trucks);

                if (cars.Count != 0)
                {
                    Console.WriteLine("Cars:");

                    foreach (var car in catalogue.CarsCollection.OrderBy(x => x.Brand))
                    {
                        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                    }
                }

                if (trucks.Count != 0)
                {
                    Console.WriteLine("Trucks:");

                    foreach (var truck in catalogue.TrucksCollection.OrderBy(x => x.Brand))
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
                }
        }
        class Car
        {
          
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

             
        }

        class Truck
        {

            
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        class CatalogueVehicle
        {
            public List<Car> CarsCollection { get; set; }
            public List<Truck> TrucksCollection { get; set; }

            public CatalogueVehicle (List<Car> cars, List<Truck> trucks)
            {
                this.CarsCollection = cars;
                this.TrucksCollection = trucks;
            }
            
        }
    }
}
