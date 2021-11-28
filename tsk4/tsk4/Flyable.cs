using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    class Flyable
    {
        public Point CurrentPosition = new Point();
        /// <summary>
        /// Current position information
        /// </summary>
        /// <returns>a Current position in string</returns>
        public override string ToString()
        {
            return $"x = {CurrentPosition.PointX} y = {CurrentPosition.PointY} z = {CurrentPosition.PointZ}";
        }
        /// <summary>
        /// Changes the current position to a point that an object flyes to
        /// </summary>
        /// <param name="destination">the Point to Fly to</param>
        public virtual void FlyTo(Point destination)
        {
            CurrentPosition.PointX = destination.PointX;
            CurrentPosition.PointY = destination.PointY;
            CurrentPosition.PointZ = destination.PointZ;
        }
        /// <summary>
        /// Counts the distance between the currrent position and the point you choose
        /// </summary>
        /// <param name="destination">the point we want to count the distance to</param>
        /// <returns></returns>
        public double GetDistance(Point destination)
        {
            double distance = Math.Sqrt(Math.Pow(destination.PointX - CurrentPosition.PointX, 2) + Math.Pow(destination.PointY - CurrentPosition.PointY, 2) + Math.Pow(destination.PointZ - CurrentPosition.PointZ, 2));
            return distance;
        }
    }
}
