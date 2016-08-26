namespace PrintSequence
{
    using System;

    class Program
    {
        static void Main()
        {
            int start = 2;
            int end = 1000;
            for (int i = 0; i < end; i++)
            {
                Console.WriteLine(start);
                if (start > 0)
                {
                    start += 1;
                }
                else
                {
                    start -= 1;
                }
                start *= -1;
            }
        }
    }
}
