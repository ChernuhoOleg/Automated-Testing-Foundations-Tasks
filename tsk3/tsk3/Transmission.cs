using System;
using System.Collections.Generic;
using System.Text;

namespace tsk3
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
        }
        public string TransmissionParams()
        {
            return $"Type of Transmission : {TypeOfTransmission}   Number Of Gears : {NumberOfGears}   Manufacturer : {Manufacturer}";
        }
    }
}
