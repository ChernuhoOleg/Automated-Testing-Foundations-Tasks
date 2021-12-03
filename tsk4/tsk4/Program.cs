using System;

namespace tsk4
{
    class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone();
            Point point = new Point(1000, 1000, 1000);
            Console.WriteLine(drone.GetFlyTime(point));

            Console.WriteLine (drone.ToString());
            Plane plane = new Plane();

            Console.WriteLine(plane.CurrentPosition);
            plane.GetFlyTime(point);
            Bird bird = new Bird();

            Console.WriteLine(bird.GetFlyTime(point));
            Console.WriteLine(plane.GetFlyTime(point));
            bird.FlyTo(point);


        }
    }
}
