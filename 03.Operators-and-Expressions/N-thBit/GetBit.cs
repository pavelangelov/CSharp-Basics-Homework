namespace N_thBit
{
    using System;

    class GetBit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int bitPossition = int.Parse(Console.ReadLine());
            long mask = 1 << bitPossition;
            long getBit = number & mask;
            long bitValue = getBit >> bitPossition;

            Console.WriteLine(bitValue);
        }
    }
}
