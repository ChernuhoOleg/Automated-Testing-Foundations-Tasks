using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : Vehicle
    {
        private const int minEnginePower = 100;

        public int AmountOfSeats { get; set; }

        public Bus(Engine engine, Chassis chassis, Transmission transmission, int amountOfSeats)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            AmountOfSeats = amountOfSeats;

            if (Engine.Size < minEnginePower)
            {
                throw new System.Exception("Bus shoud have a bigger Engine size");
            }
            if (Chassis.AmountOfWheels < 4)
            {
                throw new System.Exception("Bus can't have less than 4 wheels");
            }
        }

        public override string GeneralInfoToString() => $"{base.GeneralInfoToString()} Amount of Seats : {AmountOfSeats}";
    }
}
