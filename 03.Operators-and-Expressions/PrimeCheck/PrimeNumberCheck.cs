namespace PrimeCheck
{
    using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            double maxDivider = Math.Sqrt(number);
            bool isPrime = true;
            if (number > 0)
            {
                for (int i = divider; i <= maxDivider; i++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                    }
                    divider++;
                }
            }
            else
            {
                isPrime = false;
            }

            Console.WriteLine(isPrime ? "true" : "false");
        }
    }
}
