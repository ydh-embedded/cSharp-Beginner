## Collection

- To create a menu in a terminal in C# from a collection or List, you can use a combination of Console.WriteLine and Console.ReadLine methods to display the menu options and get user input. Here's an example:
- 
````csharp
using System;
using System.Collections.Generic;

class MenuExample
{
    static void Main(string[] args)
    {
        // Create a list of menu options
        List<string> menuOptions = new List<string>
        {
            "Option 1: Do something",
            "Option 2: Do something else",
            "Option 3: Exit"
        };

        // Display the menu
        while (true)
        {
            Console.Clear(); // Clear the console
            Console.WriteLine("Menu:");
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }

            // Get user input
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            // Parse the input
            int choice;
            if (int.TryParse(input, out choice) && choice > 0 && choice <= menuOptions.Count)
            {
                // Handle the chosen option
                switch (choice)
                {
                    case 1:
                        DoSomething();
                        break;
                    case 2:
                        DoSomethingElse();
                        break;
                    case 3:
                        Environment.Exit(0); // Exit the program
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadKey(); // Wait for user to press a key
            }
        }
    }

    static void DoSomething()
    {
        Console.WriteLine("Doing something...");
        Console.ReadKey(); // Wait for user to press a key
    }

    static void DoSomethingElse()
    {
        Console.WriteLine("Doing something else...");
        Console.ReadKey(); // Wait for user to press a key
    }
}
````