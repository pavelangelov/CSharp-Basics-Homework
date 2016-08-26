namespace SumOf5Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            double sum = 0.0;
            for (int i = 0; i < 5; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
