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

        public virtual string GeneralInfoToString()
        {
            return $"{Engine.EngineParamsToString()}\n {Transmission.TransmissionParamsToString()}\n {Chassis.ChassisParamsToString()}\n";
        }
    }
}
