using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;


namespace Task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            { new Car ( new Engine(1000, 1000, "disel", "un"), new Chassis(20, "123", 3.2), new Transmission("av", 5, "so"),"red" ),
              new Bus(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(200, "1223", 3.22), new Transmission("bigav", 10, "bigso"),6),
              new Truck(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("bigav", 10, "bigso"), "Water Tank"),
              new Scooter(new Engine(1000, 1, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("av", 10, "bigso"), true)
            };

            VehiclesByEngineSizeToXml(vehicles, 1.5);

            TruckandBusEngineInfoToXml(vehicles);

            VehiclesGroupedByTransmissionToXml(vehicles);
        }

        /// <summary>
        /// Writes information about vehicles with engines bigger than minEngineSize into a Xml file all 
        /// </summary>
        /// <param name="vehicles">Collection of vehicles</param>
        /// <param name="minEngineSize">Minimal engine size </param>
        static void VehiclesByEngineSizeToXml(List<Vehicle> vehicles, double minEngineSize)
        {
            var vehicleList = vehicles.Where(x => x.Engine.Size > minEngineSize).ToList();
            XmlSerializer formatter = new XmlSerializer(vehicleList.GetType(), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
            FileStream fileStream = new FileStream("VehiclesByEngineSize.xml", FileMode.Create);
            formatter.Serialize(fileStream, vehicleList);
        }

        /// <summary>
        /// Writes information about trucks and buses engines:serial number,engine type and power into a Xml file
        /// </summary>
        /// <param name="vehicles">collection of vehicles</param>
        static void TruckandBusEngineInfoToXml(List<Vehicle> vehicles)
        {
            FileStream fileStream = new FileStream("Truck&Bus.xml", FileMode.Create);
            var vehicleList = vehicles.Where(item => item is Bus || item is Truck)
                 .Select(item => (Power: item.Engine.Power, SerialNumber: item.Engine.SerialNumber, TypeOfEngine: item.Engine.TypeOfEngine)).ToList();
            XmlSerializer formatter = new XmlSerializer(vehicleList.GetType());
            formatter.Serialize(fileStream, vehicleList);
        }

        /// <summary>
        /// Writes information about vehicles grouped by transmission type into a Xml file
        /// </summary>
        /// <param name="vehicles">collection of vehicles</param>
        static void VehiclesGroupedByTransmissionToXml(List<Vehicle> vehicles)
        {
            FileStream fileStream = new FileStream("VehiclesGroupedByTransmission.xml", FileMode.Create);
            var groupedVehicleList = vehicles
                .GroupBy(item => item.Transmission.TypeOfTransmission)
                .Select(group => group.ToList())
                .ToList();
            XmlSerializer formatter = new XmlSerializer(groupedVehicleList.GetType(), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
            formatter.Serialize(fileStream, groupedVehicleList);
        }
    }
}
