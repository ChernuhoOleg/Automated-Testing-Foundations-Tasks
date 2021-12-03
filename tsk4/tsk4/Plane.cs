using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    class Plane: Flyable, IFlyable
    {
        const double startingSpeed = 200;
        const double maxPlaneSpeed = 900;
  
        /// <summary>
        /// Counts the speed of the plane
        /// Adds 10km/h to speed for every 10km distance because the plane accelerates
        /// </summary>
        /// <param name="destination">the point the plane flyes to </param>
        /// <returns></returns>
        //public double GetSpeed(Point destination)
        //{
        //    double speed = (int)(CurrentPosition.GetDistance(CurrentPosition, destination) / 10) * 10 + startingSpeed;
        //    if (speed > maxPlaneSpeed)
        //    {
        //        double maxSpeedTime = (CurrentPosition.GetDistance(CurrentPosition, destination) - (maxPlaneSpeed - startingSpeed)) / maxPlaneSpeed;
        //        speed = maxPlaneSpeed;
        //    }
        //    return (speed+startingSpeed)/2;
        //}
        /// <summary>
        /// Counts the time plane needs to get from current position the point you choose
        /// </summary>
        /// <param name="destination">the point the plane flyes to</param>
        /// <returns></returns>
        public double GetFlyTime(Point destination)
        {
           

            if (CurrentPosition.GetDistance(CurrentPosition, destination)< maxPlaneSpeed - startingSpeed)
            {
                double speed = (int)(CurrentPosition.GetDistance(CurrentPosition, destination) / 10) * 10 + startingSpeed;
                double time = CurrentPosition.GetDistance(CurrentPosition, destination) / ((speed+startingSpeed) / 2);
                return time;
            }
            else
            {
                double time = (maxPlaneSpeed - startingSpeed) / ((maxPlaneSpeed + startingSpeed) / 2);
                double maxSpeedTime = (CurrentPosition.GetDistance(CurrentPosition, destination) - (maxPlaneSpeed - startingSpeed)) / maxPlaneSpeed;
                return time + maxSpeedTime;
            }
            
        }
    }
}
