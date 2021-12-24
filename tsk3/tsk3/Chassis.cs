using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
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

            if (AmountOfWheels < 0 || PermissibleLoad < 0)
            {
                throw new System.ArgumentOutOfRangeException("Chassis should have a positive number as amount of wheels and permissible load");
            }
        }
        public string ChassisParamsToString() => $"Amount Of Wheels: {AmountOfWheels}   Number : {Number}   Permissible Load: {PermissibleLoad}";
    }
}
