﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private readonly string color;
        private const int minAmountofGears = 4;
        private const int maxAmountofGears = 7;

        public Car(Engine engine, Chassis chassis, Transmission transmission, string color)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            this.color = color;

            if (Transmission.NumberOfGears < minAmountofGears || Transmission.NumberOfGears > maxAmountofGears)
            {
                throw new System.Exception("A Car transmission should have from 4 to 7 gears");
            }
        }

        public override string GeneralInfoToString() => $"{base.GeneralInfoToString()} Car Color: {color}";
    }
}
