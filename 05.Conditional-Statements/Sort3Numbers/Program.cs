namespace Sort3Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            string result = "";
            if (firstNum >= secondNum)
            {
                if (firstNum >= thirdNum)
                {
                    result += firstNum.ToString() + " ";
                    if (secondNum > thirdNum)
                    {
                        result += secondNum.ToString() + " " + thirdNum.ToString();
                    }
                    else
                    {
                        result += thirdNum.ToString() + " " + secondNum.ToString();
                    }
                }
                else
                {
                    result += thirdNum.ToString() + " " + firstNum.ToString() + " " + secondNum.ToString();
                }
            }
            else if (secondNum >= thirdNum)
            {
                result += secondNum.ToString() + " ";
                if (firstNum > thirdNum)
                {
                    result += firstNum.ToString() + " " + thirdNum.ToString();
                }
                else
                {
                    result += thirdNum.ToString() + " " + firstNum.ToString();
                }
            }
            else
            {
                result += thirdNum.ToString() + " ";
                if (firstNum > secondNum)
                {
                    result += firstNum.ToString() + " " + secondNum.ToString();
                }
                else
                {
                    result += secondNum.ToString() + " " + firstNum.ToString();
                }
            }

            Console.WriteLine(result);
        }
    }
}
