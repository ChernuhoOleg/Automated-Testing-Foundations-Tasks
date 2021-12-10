using System;
using System.Collections.Generic;
using System.Text;

namespace tsk3
{
    class Scooter:Vehicle
    {
        public bool Backseat { get; set; }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission,bool backseat)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Backseat = backseat;
            if(Engine.Power>1000)
            {
               throw new System.Exception("A scooter Engine shoudn't be that powerfull") ;
            }
        }
        public override string GeneralInfoToString()
        {
            return $"{base.GeneralInfoToString()} Does it have a Bakseat? : {Backseat}";
        }
    }
}
