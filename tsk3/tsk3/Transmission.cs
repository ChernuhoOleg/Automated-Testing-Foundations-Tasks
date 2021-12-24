using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Transmission
    {
        public string TypeOfTransmission { get; set; }

        public int NumberOfGears { get; set; }

        public string Manufacturer { get; set; }

        public Transmission(string typeOfTransmission, int numberOfGears, string manufacturer)
        {
            TypeOfTransmission = typeOfTransmission;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;

            if (NumberOfGears < 0)
            {
                throw new System.ArgumentOutOfRangeException("Transmission should have a positive number as number of gears");
            }
        }
        public string TransmissionParamsToString() => $"Type of Transmission : {TypeOfTransmission}   Number Of Gears : {NumberOfGears}   Manufacturer : {Manufacturer}";
    }
}
