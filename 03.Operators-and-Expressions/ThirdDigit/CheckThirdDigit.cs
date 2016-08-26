namespace ThirdDigit
{
    using System;

    class CheckThirdDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int searchedNum = 7;
            int thirdDigit = ((number / 10) / 10) % 10;
            if (thirdDigit == searchedNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
