namespace IntDoubleString
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string value = Console.ReadLine();
            switch (input)
            {
                case "text":
                    Console.WriteLine(value + "*");
                    break;
                case "integer":
                    Console.WriteLine(int.Parse(value) + 1);
                    break;
                case "real":
                    Console.WriteLine("{0:F2}",double.Parse(value) + 1.0);
                    break;
                default:
                    break;
            }
        }
    }
}
