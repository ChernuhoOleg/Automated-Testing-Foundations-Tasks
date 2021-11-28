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
    }
}
