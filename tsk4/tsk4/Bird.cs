using System;
using System.Collections.Generic;
using System.Text;

namespace AirTransport
{
    public class Bird : Flyable, IFlyable
    {
        const int maxSpeed = 20;
        const int veryStrongWind = 30;
        const int storm = 50;

        /// <summary>
        /// Randomly generates the speed of the wind and checks if it's more than 30
        /// </summary>
        public bool WindyDay()
        {
            Random random = new Random();
            int windSpeed = random.Next(storm);
            return windSpeed > veryStrongWind;
        }

        /// <summary>
        /// Randomly generates the speed of the bird between 1 and 20
        /// </summary>
        public double GetSpeed() => new Random().Next(maxSpeed);

        /// <summary>
        /// Changes the current position to a point that the bird flyes to
        /// If it's a windy day(WindyDay==true) the bird won't fly
        /// </summary>
        /// <param name="destination">the point bird flyes to</param>
        public override void FlyTo(Point destination)
        {
            if (WindyDay())
            {
                throw new Exception("It's very windy. A Bird can't fly today, try again tomorrow ");
            }
            CurrentPosition = destination;
        }

        /// <summary>
        /// Counts the time bird needs to get from current position the point you choose
        /// </summary>
        /// <param name="destination">the point bird flyes to</param>
        /// <returns></returns>
        public double GetFlyTime(Point destination) => CurrentPosition.GetDistance(CurrentPosition, destination) / GetSpeed();
    }
}
