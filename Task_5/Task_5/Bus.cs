using System;
using System.Collections.Generic;
using System.Text;

namespace Task_5
{
    public class Bus:Vehicle
    {
        private const int minEnginePower = 100;
        public int AmountOfSeats { get; set; }
        public Bus(Engine engine, Chassis chassis, Transmission transmission,int amountOfSeats)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            AmountOfSeats = amountOfSeats;
            if(Engine.Size < minEnginePower)
            {
               throw new System.Exception("Bus shoud have a bigger Engine size") ;
            }
        }
        public Bus()
        {

        }
        public string Info()
        {
          return $"{base.GeneralInfo()} Amount of Seats : {AmountOfSeats}";
        }
    }
}
