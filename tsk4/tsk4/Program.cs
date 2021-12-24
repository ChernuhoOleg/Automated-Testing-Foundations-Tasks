using System;

namespace AirTransport
{
    public class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone();
            Point point = new Point(1000, 1000, 1000);
            Console.WriteLine(drone.GetFlyTime(point));

            Plane plane = new Plane();
            Console.WriteLine(plane.CurrentPositionInfo());
            plane.GetFlyTime(point);

            Bird bird = new Bird();
            Console.WriteLine(bird.GetFlyTime(point));
            Console.WriteLine(plane.GetFlyTime(point));
            bird.FlyTo(point);
        }
    }
}
