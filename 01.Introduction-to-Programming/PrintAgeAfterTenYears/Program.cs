namespace PrintAgeAfterTenYears
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main()
        {
            string inputDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputDate, "MM.dd.yyyy", CultureInfo.InvariantCulture);
            DateTime now = DateTime.Now;
            int howOld = now.Year - date.Year;
            if (now.Month < date.Month)
            {
                Console.WriteLine(howOld - 1);
                Console.WriteLine(howOld + 9);
            }
            else if (now.Month > date.Month)
            {
                Console.WriteLine(howOld);
                Console.WriteLine(howOld + 10);
            }
        }
    }
}
