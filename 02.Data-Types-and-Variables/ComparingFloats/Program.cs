namespace ComparingFloats
{
    using System;

    class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (firstNum > secondNum)
            {
                if ((firstNum - secondNum) >= eps)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
            else if(firstNum < secondNum)
            {
                if ((secondNum - firstNum) >= eps)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
