namespace _3rdBit
{
    using System;

    class GetThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int getBit = number & mask;
            int bit = getBit >> 3;
            Console.WriteLine(bit);
        }
    }
}
