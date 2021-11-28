using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    class Plane:Flyable,IFlyable
    {
        const int startingSpeed = 200;
        const int maxPlaneSpeed = 900;
        /// <summary>
        /// Counts the speed of the plane
        /// Adds 10km/h to speed for every 10km distance because the plane accelerates
        /// </summary>
        /// <param name="destination">the point the plane flyes to </param>
        /// <returns></returns>
        public double GetSpeed(Point destination)
        {
            double speed = (int)(GetDistance(destination) / 10) * 10 + startingSpeed;
            if (speed > maxPlaneSpeed) speed = maxPlaneSpeed;
            return speed;
        }
        /// <summary>
        /// Counts the time plane needs to get from current position the point you choose
        /// </summary>
        /// <param name="destination">the point the plane flyes to</param>
        /// <returns></returns>
        public double GetFlyTime(Point destination)
        {
            double time = GetDistance(destination) / GetSpeed(destination);
            return time;
        }
    }
}
