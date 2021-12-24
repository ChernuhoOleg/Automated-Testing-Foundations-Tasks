using System;
using System.Collections.Generic;
using System.Text;

namespace AirTransport
{
    public interface IFlyable
    {
        void FlyTo(Point destination);
        double GetFlyTime(Point destination);
    }
}
