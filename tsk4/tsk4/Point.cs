using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    struct Point
    {
        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        public Point(double x, double y, double z)
        {
            PointX = x;
            PointY = y;
            PointZ = z;
        }
        /// <summary>
        /// Counts the distance between the currrent position and the point you choose
        /// </summary>
        /// <param name="destination">the point we want to count the distance to</param>
        /// <returns></returns>
        public double GetDistance(Point currentPosition, Point destination)
        {
            double distance = Math.Sqrt(Math.Pow(destination.PointX - currentPosition.PointX, 2) + Math.Pow(destination.PointY - currentPosition.PointY, 2) + Math.Pow(destination.PointZ - currentPosition.PointZ, 2));
            return distance;
        }
    }
}
