using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // - Only words that are not already hidden are hidden.
        // - Words are hidden randomly each round.
        // - Program ends automatically when all words are hidden.

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}