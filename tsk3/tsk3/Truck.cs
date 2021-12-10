using System;
using System.Collections.Generic;
using System.Text;

namespace tsk3
{
    class Truck:Vehicle
    {
        private const int minAmountOfWheels = 4;
        public string TrunkType { get; set; }

        public Truck(Engine engine, Chassis chassis, Transmission transmission,string trunkType)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            TrunkType = trunkType;
            if(Chassis.AmountOfWheels < minAmountOfWheels)
            { 
                throw new System.Exception($"Truck can't have less then {minAmountOfWheels} wheels");
            }

        }
        public override string GeneralInfoToString()
        {
            return $"{base.GeneralInfoToString()} Trunk Type : {TrunkType}";
        }
    }
}
