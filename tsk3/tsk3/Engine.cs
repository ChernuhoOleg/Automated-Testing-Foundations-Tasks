using System;
using System.Collections.Generic;
using System.Text;

namespace tsk3
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
        }
        public string EngineParamsToString()
        { 
            return $"Power : {Power}  Size : {Size}  Type of Engine : {TypeOfEngine}  Serial Number :{SerialNumber}"; 
        }

    }
}
