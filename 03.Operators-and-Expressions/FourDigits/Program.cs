namespace FourDigits
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int length = input.Length;
            int inputNum = int.Parse(input);
            string reversedNum = "";
            int sum = 0;
            string lastDigitGoesFirst = input[length -1].ToString();
            for (int i = 0; i < length; i++)
            {
                reversedNum += input[length - i - 1];

                sum += inputNum % 10;
                inputNum /= 10;

                if (i < length - 1)
                {
                    lastDigitGoesFirst += input[i];
                }
            }

            string reversDigitsInTheMidle = "" + input[0] + input[2] + input[1] + input[3];

            Console.WriteLine(sum);
            Console.WriteLine(reversedNum);
            Console.WriteLine(lastDigitGoesFirst);
            Console.WriteLine(reversDigitsInTheMidle);
        }
    }
}
