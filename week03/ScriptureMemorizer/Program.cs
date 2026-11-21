using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVITY AND EXCEEDING REQUIREMENTS:
        // This program uses a library of three scriptures and randomly
        // selects one each time the program runs.
        // It also hides only visible words, three at a time, and displays
        // the number of words remaining to help users track their progress.

        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("Doctrine and Covenants", 64, 33),
            "Wherefore be not weary in well doing for ye are laying the foundation of a great work. And out of small things proceedeth that which is great."
        ));

        Random random = new Random();

        int selectedIndex = random.Next(scriptureLibrary.Count);

        Scripture selectedScripture = scriptureLibrary[selectedIndex];

        Console.Clear();

        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine("-------------------");
        Console.WriteLine();

        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Press ENTER to hide words or type 'quit' to exit.");

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Write("\nYour choice: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("\nThank you for using Scripture Memorizer!");
                return;
            }

            selectedScripture.HideRandomWords(3);

            Console.Clear();

            Console.WriteLine("SCRIPTURE MEMORIZER");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine(
                "Words remaining: " +
                selectedScripture.GetVisibleWordCount()
            );

            if (!selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine(
                    "\nPress ENTER to hide more words or type 'quit' to exit."
                );
            }
        }

        Console.WriteLine("\nAll words have been hidden!");
        Console.WriteLine("Great job practicing your scripture!");
    }
}