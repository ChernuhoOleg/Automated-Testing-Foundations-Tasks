using System;
using System.Collections.Generic;
using System.Text;

namespace AirTransport
{
    public class Drone : Flyable, IFlyable
    {
        const int speed = 25;
        const int maxFlightDistance = 1000;
        const double timeToStop = 10;
        const double stopTime = 1;
        const double minutesToHours = 60;

        /// <summary>
        /// Changes the current position to a point that an drone flyes to. If the distance is more than maxFlightDistance drone won't fly.
        /// </summary>
        /// <param name="destination">the point we fly to</param>
        public override void FlyTo(Point destination)
        {
            if (CurrentPosition.GetDistance(CurrentPosition, destination) > maxFlightDistance)
            {
                throw new Exception("Drone can't fly that far");
            }
            CurrentPosition = destination;
        }

        /// <summary>
        /// Counts the time Drone needs to get from current position the point you choose
        /// Every 10 minutes adds a minute to time because the drone stops
        /// </summary>
        /// <param name="destination">the point that we need to know the time to fly to</param>
        /// <returns></returns>
        public double GetFlyTime(Point destination)
        {
            double time = CurrentPosition.GetDistance(CurrentPosition, destination) / speed;
            double addtime = (int)(time / (timeToStop / minutesToHours)) * (stopTime / minutesToHours);
            return time + addtime;
        }
    }
}
