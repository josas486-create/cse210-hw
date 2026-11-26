using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> activityLog = new List<string>();

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. View Activity History");
            Console.WriteLine("  5. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

                activityLog.Add($"{activity.GetName()} - {DateTime.Now}");
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();

                activityLog.Add($"{activity.GetName()} - {DateTime.Now}");
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();

                activityLog.Add($"{activity.GetName()} - {DateTime.Now}");
            }
            else if (choice == "4")
            {
                Console.Clear();

                Console.WriteLine("ACTIVITY HISTORY");
                Console.WriteLine();

                if (activityLog.Count == 0)
                {
                    Console.WriteLine("No activities completed yet.");
                }
                else
                {
                    foreach (string activity in activityLog)
                    {
                        Console.WriteLine(activity);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}

/*
CREATIVITY AND EXCEEDING REQUIREMENTS:

1. Added an Activity History option to the menu.
2. The program records completed activities with their completion dates.
3. Users can view their activity history during the session.

These additions make it easier for users to keep track of their mindfulness activities.
*/