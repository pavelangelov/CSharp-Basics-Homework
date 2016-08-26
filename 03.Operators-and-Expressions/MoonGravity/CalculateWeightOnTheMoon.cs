namespace MoonGravity
{
    using System;
    using System.Globalization;

    class CalculateWeightOnTheMoon
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weight * 0.17;
            Console.WriteLine(weightOnTheMoon.ToString("F3",
                  CultureInfo.InvariantCulture));
        }
    }
}
