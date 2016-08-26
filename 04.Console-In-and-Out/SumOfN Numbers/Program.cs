namespace SumOfN_Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0.0;
            for (int i = 0; i < n; i++)
            {
                result += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
