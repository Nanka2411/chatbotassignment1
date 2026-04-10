using System;
class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";

        UIHelper.DisplayLogo();

        // Ask user name
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nEnter your name: ");
        Console.ResetColor();

        string nameInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nameInput))
        {
            nameInput = "User";
        }

        // Create user object
        User user = new User { Name = nameInput };

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nHello {user.Name}! Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("You can ask me questions about .....ANYTHING CYBER !:");
        Console.WriteLine("1. Password safety");
        Console.WriteLine("2. Phishing");
        Console.WriteLine("3. Safe browsing");
        Console.WriteLine("4. Malware");
        Console.WriteLine("5. Public WiFi\t");
        
        Console.WriteLine("Type 'exit' to close the chatbot.");

        // Start chatbot
        Chat.StartChat(user);
    }
}

      
