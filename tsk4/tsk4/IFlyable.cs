using System;
using System.Collections.Generic;
using System.Text;

namespace tsk4
{
    interface IFlyable
    {
        void FlyTo(Point destination);
        double GetDistance(Point destination);
        double GetFlyTime(Point destination);

    }
}
