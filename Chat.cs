using System;

class Chat
{
    public static void StartChat(User user)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nYou: ");
            Console.ResetColor();


            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
       

                Console.WriteLine("Bot: Please type a question.");
                continue;
            }

            input = input.ToLower();

            if (input.Contains("exit"))
            {
                Console.WriteLine($"Bot: Goodbye {user.Name}! Stay safe online.");
                break;
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine($"Bot: I'm doing great {user.Name}! Ready to help with cybersecurity questions.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to educate users about cybersecurity awareness.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong passwords with uppercase, lowercase, numbers, and symbols.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is a scam where attackers trick you into revealing personal information through fake emails or websites.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Always check the website URL and avoid clicking suspicious links.");
            }
            else if (input.Contains("malware"))
            {
                Console.WriteLine("Bot:Malware is short for ther term \"malicious software\" basically any software or program that is designed to harm,exploiy or take control of a computer deveice without a user's permision");
            }
            else if (input.Contains("wifi"))
            {
                Console.WriteLine("Bot: Public WiFi can be unsafe. Avoid accessing sensitive accounts on public networks.");
            }
            else
            {
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
            }
                }
            }
        }
   
