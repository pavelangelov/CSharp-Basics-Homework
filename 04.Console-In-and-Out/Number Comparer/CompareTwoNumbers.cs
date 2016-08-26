namespace Number_Comparer
{
    using System;

    class CompareTwoNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double greater = Math.Max(a, b);

            Console.WriteLine(greater);
        }
    }
}
