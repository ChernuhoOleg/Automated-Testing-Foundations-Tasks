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
    class Program
    {
        static void Main(string[] args)
        {
             List<Vehicle> vehicles = new List<Vehicle>
            { new Car ( new Engine(1000, 1000, "disel", "un"), new Chassis(20, "123", 3.2), new Transmission("av", 5, "so"),"red" ),
              new Bus(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(200, "1223", 3.22), new Transmission("bigav", 10, "bigso"),6),
              new Truck(new Engine(10000, 10000, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("bigav", 10, "bigso"), "Water Tank"),
              new Scooter(new Engine(1000, 1, "bigdisel", "bigun"), new Chassis(10, "1223", 3.22), new Transmission("av", 10, "bigso"), true)
            };

            VehiclesByEngineSizeToXml(vehicles);
            TruckandBusEngineInfo(vehicles);
            VehiclesGroupedByTransmissionToXml(vehicles);
        }
         static void VehiclesByEngineSizeToXml(List<Vehicle> vehicles)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Vehicle), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
            using (FileStream fs = new FileStream("VehiclesByEngineSize.xml", FileMode.Create))
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Engine.Size > 1.5)
                    {
                        formatter.Serialize(fs, vehicle);
                    }
                }

            }
        }
        static void TruckandBusEngineInfo(List<Vehicle> vehicles)
        {
            XDocument xdoc = new XDocument();
            XElement vehiclesElem = new XElement("Vehicles");
            // создаем первый элемент
            foreach (Vehicle item in vehicles)
            {
                if (item.ToString() == "Task_5.Bus" || item.ToString() == "Task_5.Truck")
                {
                    XElement vehicle = new XElement("Vehicle");
                    XElement engine = new XElement("Engine");
                    XAttribute vehicleAttr = new XAttribute("type", item.ToString());
                    XElement engineTypeElem = new XElement("type_of_Engine", item.Engine.TypeOfEngine.ToString());
                    XElement enginePowerElem = new XElement("power", item.Engine.Power.ToString());
                    XElement engineNumberElem = new XElement("serial_number", item.Engine.SerialNumber.ToString());
                    vehicle.Add(vehicleAttr);
                    engine.Add(engineTypeElem);
                    engine.Add(engineNumberElem);
                    engine.Add(enginePowerElem);
                    vehicle.Add(engine);
                    vehiclesElem.Add(vehicle);
                }
            }

            xdoc.Add(vehiclesElem);
            xdoc.Save("Truck&Bus.xml");

        }
 
        static void VehiclesGroupedByTransmissionToXml(List<Vehicle> vehicles)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Vehicle), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
            FileStream fs = null;
            fs = new FileStream("VehiclesGroupedByTransmission.xml", FileMode.Create);
                var vehicleGroups = from vehicle in vehicles
                                group vehicle by vehicle.Transmission.TypeOfTransmission.ToString();
            foreach (IGrouping<string, Vehicle> group in vehicleGroups)
            {
                foreach (var groupItem in group)
                {
                        formatter.Serialize(fs, groupItem);
                }

            }

        }
}
}
