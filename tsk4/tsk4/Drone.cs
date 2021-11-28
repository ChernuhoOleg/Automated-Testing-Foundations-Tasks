using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    class Drone :Flyable,IFlyable
    {
        const int speed = 25;
        const int maxFlightDistance = 1000;
        const int timeToStop = 10;
        const int stopTime = 1;
        const int minutesToHours = 60;
        /// <summary>
        /// Changes the current position to a point that an drone flyes to. If the distance is more than maxFlightDistance drone won't fly.
        /// </summary>
        /// <param name="destination">the point we fly to</param>
        public override void FlyTo(Point destination)
        {
            if( GetDistance(destination) > maxFlightDistance)
            {
                throw new Exception("Drone can't fly that far");
            }
            CurrentPosition.PointX = destination.PointX;
            CurrentPosition.PointY = destination.PointY;
            CurrentPosition.PointZ = destination.PointZ;
        }

        /// <summary>
        /// Counts the time Drone needs to get from current position the point you choose
        /// Every 10 minutes adds a minute to time because the drone stops
        /// </summary>
        /// <param name="destination">the point that we need to know the time to fly to</param>
        /// <returns></returns>
        public double GetFlyTime(Point destination)
        {
            double time = GetDistance(destination) / speed;

            return (int)(time/(timeToStop/minutesToHours)*(stopTime/minutesToHours)) +time;
        }

}
}
