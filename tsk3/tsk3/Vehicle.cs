using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vehicle
    {
        public Engine Engine { get; set; }

        public Chassis Chassis { get; set; }

        public Transmission Transmission { get; set; }

        public virtual string GeneralInfoToString() => $"{Engine.EngineParamsToString()}\n {Transmission.TransmissionParamsToString()}\n {Chassis.ChassisParamsToString()}\n";
    }
}
