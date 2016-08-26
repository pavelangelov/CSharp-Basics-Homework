namespace BitSwap
{
    using System;

    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint firstMask;
            uint secondMask;
            uint getFirstBit;
            uint getSecondBit;
            uint firstBit;
            uint secondBit;
            uint currentNumber;

            for (int i = 1; i <+ k; i++)
            {
                firstMask = (uint)(1 << (p + i));
                secondMask = (uint)(1 << (q + i));
                getFirstBit = n & firstMask;
                getSecondBit = n & secondMask;
                firstBit = getFirstBit >> (p + i);
                secondBit = getSecondBit >> (q + i);

                if (firstBit == secondBit)
                {
                    continue;
                }
                if (secondBit == 1)
                {
                    currentNumber = n | firstMask;
                }
                else
                {
                    currentNumber = n ^ firstMask;
                }
                n = currentNumber;

                if (firstBit == 1)
                {
                    currentNumber = n | secondMask;
                }
                else
                {
                    currentNumber = n ^ secondMask;
                }

                n = currentNumber;
            }

            Console.WriteLine(n);
        }
    }
}
