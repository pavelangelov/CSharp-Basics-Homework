namespace PrintTheASCIITable
{
    using System;

    class Program
    {
        static void Main()
        {
            int start = 33;
            int end = 126;
            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i);
            }

            Console.WriteLine();
        }
    }
}
