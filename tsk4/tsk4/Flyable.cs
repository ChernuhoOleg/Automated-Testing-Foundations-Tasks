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
        /// <returns>Current position in string</returns>
        public string CurrentPositionInfo()
        {
            return $"x = {CurrentPosition.PointX} y = {CurrentPosition.PointY} z = {CurrentPosition.PointZ}";
        }
        /// <summary>
        /// Changes the current position to a point that an object flyes to.
        /// </summary>
        /// <param name="destination">the point we fly to</param>
        public virtual void FlyTo(Point destination)
        {
            CurrentPosition = destination;
        }

    }
}
