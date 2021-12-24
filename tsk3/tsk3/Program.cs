using System;


namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Engine(1000, 1000, "disel", "un"), new Chassis(20, "123", 3.2), new Transmission("av", 5, "so"), "red");
            Console.WriteLine(car.GeneralInfoToString());

            Bus bus = new Bus(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(200, "1223", 3.22), new Transmission("bigav", 10, "bigso"), 6);
            Console.WriteLine(bus.GeneralInfoToString());

            Truck truck = new Truck(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("bigav", 10, "bigso"), "Water Tank");
            Console.WriteLine(truck.GeneralInfoToString());

            Scooter scooter = new Scooter(new Engine(100, 10000, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("bigav", 10, "bigso"), true);
            Console.WriteLine(scooter.GeneralInfoToString());
        }
    }
}
