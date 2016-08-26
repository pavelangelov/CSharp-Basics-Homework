namespace ModifyBit
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int bitPossition = int.Parse(Console.ReadLine());
            int bitValue = int.Parse(Console.ReadLine());
            int mask = 1 << bitPossition;
            int changeBit;
            if (bitValue == 0)
            {
                changeBit = number ^ mask;
            }
            else
            {
                changeBit = number | mask;
            }

            Console.WriteLine(changeBit);
        }
    }
}
