using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Chassis
    {
        public int AmountOfWheels { get; set; }
        public string Number { get; set; }
        public double PermissibleLoad { get; set; }

        public Chassis(int amountOfWheels, string number, double permissibleLoad)
        {
            AmountOfWheels = amountOfWheels;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }
        public Chassis()
        {

        }
        public string ChassisParams()
        {
            return $"Amount Of Wheels: {AmountOfWheels}   Number : {Number}   Permissible Load: {PermissibleLoad}";
        }
    }
}
