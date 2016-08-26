namespace Point__Circle__Rectangle
{
    using System;

    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double circleX = 1;
            double circleY = 1;
            double circleRadius = 1.5;

            double distanceX = (x - circleX) * (x - circleX);
            double distanceY = (y - circleY) * (y - circleY);
            double d = Math.Sqrt(distanceX + distanceY);
            bool isInCircle = d <= circleRadius;
            bool isInRect = true;

            if (y < -1 || y > 1)
            {
                isInRect = false;
            }

            if (x < -1 || x > 5)
            {
                isInRect = false;
            }

            if (isInCircle && isInRect)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (isInCircle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (isInRect)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }

        }
    }
}
