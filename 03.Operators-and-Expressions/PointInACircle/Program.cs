namespace PointInACircle
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double circleX = 0;
            double circleY = 0;
            double circleRadius = 2;

            double distanceX = (x - circleX) * (x - circleX);
            double distanceY = (y - circleY) * (y - circleY);
            double d = Math.Sqrt(distanceX + distanceY);

            if (d <= circleRadius)
            {
                Console.WriteLine("yes {0}", d.ToString("F", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("no {0}", d.ToString("F", CultureInfo.InvariantCulture));
            }
        }
    }
}
