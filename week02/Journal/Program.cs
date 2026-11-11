using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity feature: The journal includes mood tracking.
        // This allows users to record how they felt during each day,
        // making their journal more personal and useful for reflection.

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        Console.WriteLine("Welcome to your Personal Journal!");

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine() ?? "";

            if (!int.TryParse(userInput, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                choice = 0;
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine() ?? "";

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine() ?? "";

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);

                Console.WriteLine("Your entry has been added!");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine() ?? "";

                if (filename != "")
                {
                    try
                    {
                        theJournal.SaveToFile(filename);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to save the journal.");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine() ?? "";

                if (filename != "")
                {
                    try
                    {
                        theJournal.LoadFromFile(filename);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Unable to load the journal.");
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using your Personal Journal. Goodbye!");
            }
            else
            {
                Console.WriteLine("Please select an option between 1 and 5.");
            }
        }
    }
}