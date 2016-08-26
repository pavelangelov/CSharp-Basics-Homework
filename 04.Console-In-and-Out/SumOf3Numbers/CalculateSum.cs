namespace SumOf3Numbers
{
    using System;

    class CalculateSum
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double sum = firstNum + secondNum + thirdNum;

            Console.WriteLine(sum);
        }
    }
}
