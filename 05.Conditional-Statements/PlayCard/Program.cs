namespace PlayCard
{
    using System;
    
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] cards = new string[13]{
                "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };
            bool content = false;

            for (int i = 0; i < cards.Length; i++)
            {
                if (input == cards[i])
                {
                    content = true;
                    Console.WriteLine("yes {0}", input);
                }
            }

            if (!content)
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
}
