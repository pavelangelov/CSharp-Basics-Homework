namespace BiggestOf5
{
    using System;

    class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double max = firstNum;
            for (int i = 0; i < 4; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
