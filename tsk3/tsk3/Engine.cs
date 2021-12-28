using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Engine
    {
        public double Power { get; set; }

        public double Size { get; set; }

        public string TypeOfEngine { get; set; }

        public string SerialNumber { get; set; }

        public Engine(double power, double size, string typeOfEngine, string serialNumber)
        {
            Power = power;
            Size = size;
            TypeOfEngine = typeOfEngine;
            SerialNumber = serialNumber;

            if (Power < 0 || Size < 0)
            {
                throw new System.ArgumentOutOfRangeException("Engine should have a positive number as power and size");
            }
        }

        public string EngineParamsToString() => $"Power : {Power}  Size : {Size}  Type of Engine : {TypeOfEngine}  Serial Number :{SerialNumber}";
    }
}
