namespace Trapezoids
{
    using System;
    using System.Globalization;

    class CalculateTrapezoidArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = h * ((a + b) / 2);

            Console.WriteLine(area.ToString("F7", CultureInfo.InvariantCulture));
        }
    }
}
