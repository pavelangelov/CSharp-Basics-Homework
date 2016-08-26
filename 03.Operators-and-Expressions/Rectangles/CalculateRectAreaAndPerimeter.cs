namespace Rectangles
{
    using System;
    using System.Globalization;

    class CalculateRectAreaAndPerimeter
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectArea = (width * height);
            double rectPerimeter = (width + height) * 2;

            Console.WriteLine(rectArea.ToString("F", CultureInfo.InvariantCulture) + " " + 
                                rectPerimeter.ToString("F", CultureInfo.InvariantCulture));
        }
    }
}
