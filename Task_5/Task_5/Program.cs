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
            var vehicleList = vehicles.Where(x => x.Engine.Size > 1.5).ToList();
            XmlSerializer formatter = new XmlSerializer(vehicleList.GetType(), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
            using (FileStream fs = new FileStream("VehiclesByEngineSize.xml", FileMode.Create))
 
                    formatter.Serialize(fs, vehicleList);


        }
        static void TruckandBusEngineInfo(List<Vehicle> vehicles)
        {
            var vehicleList = vehicles.Where(x => x.ToString() == "Task_5.Bus" || x.ToString() == "Task_5.Truck");
            var engines =  vehicleList.Select(e => (e.Engine.Power, e.Engine.SerialNumber, e.Engine.TypeOfEngine)).ToList();
            XmlSerializer formatter = new XmlSerializer(engines.GetType(), new Type[] { typeof(Engine)});
            using (FileStream fs = new FileStream("Truck&Bus.xml", FileMode.Create))
                formatter.Serialize(fs, engines);



            //XDocument xdoc = new XDocument();
            //XElement vehiclesElem = new XElement("Vehicles");
            //// создаем первый элемент
            //foreach (Vehicle item in vehicles)
            //{
            //    if (item.ToString() == "Task_5.Bus" || item.ToString() == "Task_5.Truck")
            //    {
            //        XElement vehicle = new XElement("Vehicle");
            //        XElement engine = new XElement("Engine");
            //        XAttribute vehicleAttr = new XAttribute("type", item.ToString());
            //        XElement engineTypeElem = new XElement("type_of_Engine", item.Engine.TypeOfEngine.ToString());
            //        XElement enginePowerElem = new XElement("power", item.Engine.Power.ToString());
            //        XElement engineNumberElem = new XElement("serial_number", item.Engine.SerialNumber.ToString());
            //        vehicle.Add(vehicleAttr);
            //        engine.Add(engineTypeElem);
            //        engine.Add(engineNumberElem);
            //        engine.Add(enginePowerElem);
            //        vehicle.Add(engine);
            //        vehiclesElem.Add(vehicle);
            //    }
            //}

            //xdoc.Add(vehiclesElem);
            //xdoc.Save("Truck&Bus.xml");

        }
 
        static void VehiclesGroupedByTransmissionToXml(List<Vehicle> vehicles)
        {
            FileStream fs = null;
            fs = new FileStream("VehiclesGroupedByTransmission.xml", FileMode.Create);
            var groupedVehicleList = vehicles
                .GroupBy(u => u.Transmission.TypeOfTransmission.ToString())
                .Select(grp => grp.ToList())
                .ToList();
            XmlSerializer formatter = new XmlSerializer(groupedVehicleList.GetType(), new Type[] { typeof(Car), typeof(Scooter), typeof(Truck), typeof(Bus) });
               formatter.Serialize(fs, groupedVehicleList);
                

        }
}
}
