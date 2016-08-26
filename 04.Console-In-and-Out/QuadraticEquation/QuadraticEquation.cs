namespace QuadraticEquation
{
    using System;

    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - 4 * (a * c);

            if (d > 0)
            {
                double firstRoot = (-b - Math.Sqrt(d)) / (2 * a);
                double secondRoot = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0:F2}",firstRoot);
                Console.WriteLine("{0:F2}", secondRoot);
            }
            else if (d == 0)
            {
                double root = -(b / (2 * a));
                Console.WriteLine("{0:F2}", root);
            }
            else
            {
                Console.WriteLine("no real roots");
            } 

        }
    }
}
