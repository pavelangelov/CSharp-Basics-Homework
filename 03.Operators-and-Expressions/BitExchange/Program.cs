namespace BitExchange
{
    using System;

    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int[] bits = new int[6] { 3, 4, 5, 24, 25, 26 };
            long firstMask;
            long secondMask;
            long getFirstBit;
            long getSecondBit;
            long currentNumber = 0;
            long firstBit;
            long secondBit;

            for (int i = 0; i < 3; i++)
            {
                firstMask = 1 << bits[i];
                secondMask = 1 << bits[i + 3];
                getFirstBit = number & firstMask;
                getSecondBit = number & secondMask;
                firstBit = getFirstBit >> bits[i];
                secondBit = getSecondBit >> bits[i + 3];

                if (firstBit == secondBit)
                {
                    continue;
                }
                if (secondBit == 1)
                {
                    currentNumber = number | firstMask;
                }
                else
                {
                    currentNumber = number ^ firstMask;
                }
                number = currentNumber;

                if (firstBit == 1)
                {
                    currentNumber = number | secondMask;
                }
                else
                {
                    currentNumber = number ^ secondMask;
                }

                number = currentNumber;
            }

            Console.WriteLine(number);
        }
    }
}
