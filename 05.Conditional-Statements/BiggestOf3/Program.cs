namespace BiggestOf3
{
    using System;

    class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double firstGreater = Math.Max(firstNum, secondNum);

            Console.WriteLine(Math.Max(firstGreater, thirdNum));
        }
    }
}
