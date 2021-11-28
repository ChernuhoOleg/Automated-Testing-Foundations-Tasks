using System;
using System.Collections.Generic;
using System.Text;

namespace tsk3
{
    public class Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public string GeneralInfo()
        {
            return $"{Engine.EngineParams()}\n {Transmission.TransmissionParams()}\n {Chassis.ChassisParams()}\n";
        }
    }
}
