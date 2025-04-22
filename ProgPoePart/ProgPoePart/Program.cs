


using System;
using System.Media;
using System.Threading;
using System.IO;

class CyberAwarenessChatbot
{
    static void Main(string[] args)
    {
        Console.Title = "Cyber Awareness Hub";

        // Display enhanced ASCII art
        DisplayCyberShieldArt();

        // Play welcome audio (uncomment when WAV file is available)
        PlayWelcomeAudio();

        // Enhanced typewriter effect with colors
        ColorTypeWrite("Initializing Cyber Awareness Hub...\n", ConsoleColor.Cyan);
        Thread.Sleep(1000);

        // Get user's name with validation
        string userName = GetUserName();

        // Main interaction loop
        RunChatLoop(userName);
    }

    static void DisplayCyberShieldArt()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@"
    ____          __    ______                            __    
   / __ \ _____  / /_  / ____/___   ____ _ ____   ____   / /____
  / / / // ___/ / __/ / /    / _ \ / __ `// __ \ / __ \ / // __/
 / /_/ // /__  / /_  / /___ /  __// /_/ // / / // /_/ // // /_  
/_____/ \___/  \__/  \____/ \___/ \__,_//_/ /_/ \____//_/ \__/  
                                                                 
   _____              _                    _____                          
  / ____|            | |                  / ____|                         
 | |      __ _  _ __ | |_  ___  _ __     | (___   ___   _ __ ___   _ __   
 | |     / _` || '__|| __|/ _ \| '_ \     \___ \ / _ \ | '_ ` _ \ | '_ \  
 | |____| (_| || |   | |_|  __/| | | |    ____) | (_) || | | | | || |_) | 
  \_____|\__,_||_|    \__|\___||_| |_|   |_____/ \___/ |_| |_| |_|| .__/  
                                                                  | |    
                                                                  |_|    
");
        Console.ResetColor();
    }

    static void PlayWelcomeAudio()
    {
        try
        {
            string filePath = "Audio images/greetings.wav"; // Make sure this path is correct relative to the executable

            SoundPlayer player = new SoundPlayer(filePath);
            player.Play(); // Use PlaySync() if you want it to block until audio finishes
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("[Audio greeting not found]");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error playing audio]: {ex.Message}");
        }
    }

    static void ColorTypeWrite(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            Thread.Sleep(20);
        }
        Console.ResetColor();
    }

    static string GetUserName()
    {
        string userName = "";
        while (string.IsNullOrWhiteSpace(userName))
        {
            ColorTypeWrite("\n🔒 Welcome to Cyber Awareness Hub!\n", ConsoleColor.Yellow);
            ColorTypeWrite("Before we begin, what should I call you? ", ConsoleColor.White);
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                ColorTypeWrite("⚠️  I didn't catch that. Please enter your name: ", ConsoleColor.Red);
            }
        }

        Console.WriteLine();
        ColorTypeWrite($"🛡️  Welcome, {userName}! I'm your Cyber Awareness Assistant.\n", ConsoleColor.Green);
        ColorTypeWrite("I'm here to help you stay safe in the digital world.\n\n", ConsoleColor.Cyan);
        Thread.Sleep(800);

        return userName;
    }

    static void RunChatLoop(string userName)
    {
        bool continueChat = true;
        while (continueChat)
        {
            DisplayMainMenu();
            string userInput = GetUserInput();

            if (userInput.ToLower() == "exit")
            {
                continueChat = false;
                DisplayFarewell(userName);
            }
            else
            {
                ProcessCyberRequest(userInput, userName);
            }
        }
    }

    static void DisplayMainMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n┌──────────────────────────────────────────────┐");
        Console.WriteLine("│            CYBER AWARENESS MENU             │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.WriteLine("│ 1. Password Security                        │");
        Console.WriteLine("│ 2. Phishing Threats                         │");
        Console.WriteLine("│ 3. Secure Browsing                          │");
        Console.WriteLine("│ 4. Social Media Safety                      │");
        Console.WriteLine("│ 5. About This Hub                           │");
        Console.WriteLine("│                                              │");
        Console.WriteLine("│ (Type 'exit' to quit)                        │");
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
        Console.Write("\n🛡️  What cyber topic interests you today? ");
    }

    static string GetUserInput()
    {
        string input = Console.ReadLine()?.Trim() ?? "";
        while (string.IsNullOrWhiteSpace(input))
        {
            ColorTypeWrite("⚠️  Please enter a valid choice: ", ConsoleColor.Red);
            input = Console.ReadLine()?.Trim() ?? "";
        }
        return input;
    }

    static void ProcessCyberRequest(string input, string userName)
    {
        Console.WriteLine();

        switch (input.ToLower())
        {
            case "1":
            case "password":
            case "password security":
                DisplayPasswordSecurity(userName);
                break;

            case "2":
            case "phishing":
            case "phishing threats":
                DisplayPhishingThreats(userName);
                break;

            case "3":
            case "browsing":
            case "secure browsing":
                DisplaySecureBrowsing(userName);
                break;

            case "4":
            case "social media":
            case "social media safety":
                DisplaySocialMediaSafety(userName);
                break;

            case "5":
            case "about":
                DisplayAboutHub();
                break;

            default:
                ColorTypeWrite("⚠️  I'm not sure about that topic. ", ConsoleColor.Red);
                ColorTypeWrite("Here are the topics I can help with:\n", ConsoleColor.White);
                DisplayMainMenu();
                break;
        }
    }

    static void DisplayPasswordSecurity(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌──────────────────────────────────────────────┐");
        Console.WriteLine("│            PASSWORD SECURITY GUIDE           │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite($"\n{userName}, strong passwords are your first line of defense!\n\n", ConsoleColor.Cyan);
        ColorTypeWrite("🔐 Create passwords with:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Minimum 12 characters (longer is better!)\n", ConsoleColor.White);
        ColorTypeWrite("• Mix of uppercase, lowercase, numbers & symbols\n", ConsoleColor.White);
        ColorTypeWrite("• Avoid dictionary words and personal information\n\n", ConsoleColor.White);

        ColorTypeWrite("🔄 Password Management Tips:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Use a unique password for every account\n", ConsoleColor.White);
        ColorTypeWrite("• Consider a password manager (Bitwarden, 1Password)\n", ConsoleColor.White);
        ColorTypeWrite("• Enable two-factor authentication (2FA) everywhere\n", ConsoleColor.White);
        ColorTypeWrite("• Change passwords after security breaches\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
    }

    static void DisplayPhishingThreats(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("┌──────────────────────────────────────────────┐");
        Console.WriteLine("│            PHISHING THREATS ALERT            │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite($"\n{userName}, phishing is the #1 cyber attack method!\n\n", ConsoleColor.Cyan);
        ColorTypeWrite("🎣 Common Phishing Tactics:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Urgent messages claiming your account is compromised\n", ConsoleColor.White);
        ColorTypeWrite("• Fake login pages that steal credentials\n", ConsoleColor.White);
        ColorTypeWrite("• Impersonation of trusted organizations\n", ConsoleColor.White);
        ColorTypeWrite("• Too-good-to-be-true offers\n\n", ConsoleColor.White);

        ColorTypeWrite("🛡️  Protection Strategies:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Verify sender email addresses carefully\n", ConsoleColor.White);
        ColorTypeWrite("• Hover over links to see real destinations\n", ConsoleColor.White);
        ColorTypeWrite("• Never enter credentials from email links\n", ConsoleColor.White);
        ColorTypeWrite("• Report suspicious messages to your IT team\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
    }

    static void DisplaySecureBrowsing(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("┌──────────────────────────────────────────────┐");
        Console.WriteLine("│            SECURE BROWSING PRACTICES         │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite($"\n{userName}, safe browsing protects you from malware and scams!\n\n", ConsoleColor.Cyan);
        ColorTypeWrite("🌐 Browser Security Essentials:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Always look for HTTPS:// and 🔒 padlock icon\n", ConsoleColor.White);
        ColorTypeWrite("• Keep browsers and plugins updated\n", ConsoleColor.White);
        ColorTypeWrite("• Use privacy-focused browsers (Brave, Firefox)\n", ConsoleColor.White);
        ColorTypeWrite("• Install reputable security extensions\n\n", ConsoleColor.White);

        ColorTypeWrite("🚫 Dangerous Behaviors to Avoid:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Disabling security warnings\n", ConsoleColor.White);
        ColorTypeWrite("• Ignoring certificate errors\n", ConsoleColor.White);
        ColorTypeWrite("• Downloading files from untrusted sources\n", ConsoleColor.White);
        ColorTypeWrite("• Allowing all cookies and trackers\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
    }

    static void DisplaySocialMediaSafety(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("┌──────────────────────────────────────────────┐");
        Console.WriteLine("│           SOCIAL MEDIA SAFETY GUIDE          │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite($"\n{userName}, social media requires special security awareness!\n\n", ConsoleColor.Cyan);
        ColorTypeWrite("📱 Privacy Protection Tips:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Review privacy settings monthly\n", ConsoleColor.White);
        ColorTypeWrite("• Limit personal information sharing\n", ConsoleColor.White);
        ColorTypeWrite("• Be cautious with location tagging\n", ConsoleColor.White);
        ColorTypeWrite("• Assume anything posted is permanent\n\n", ConsoleColor.White);

        ColorTypeWrite("⚠️ Social Engineering Risks:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Fake profiles conducting reconnaissance\n", ConsoleColor.White);
        ColorTypeWrite("• \"Friend\" requests from strangers\n", ConsoleColor.White);
        ColorTypeWrite("• Surveys harvesting personal data\n", ConsoleColor.White);
        ColorTypeWrite("• Malicious links disguised as videos/news\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
    }

    static void DisplayAboutHub()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("┌──────────────────────────────────────────────┐");
        Console.WriteLine("│             ABOUT CYBER AWARENESS HUB         │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite("\n🛡️ Cyber Awareness Hub v2.0\n\n", ConsoleColor.Cyan);
        ColorTypeWrite("Mission: Empower users with essential cybersecurity knowledge\n", ConsoleColor.White);
        ColorTypeWrite("Developed for educational purposes\n", ConsoleColor.White);
        ColorTypeWrite("© 2025 Cyber Security Education Initiative\n\n", ConsoleColor.White);

        ColorTypeWrite("🔗 Features:\n", ConsoleColor.Yellow);
        ColorTypeWrite("• Interactive cyber safety guidance\n", ConsoleColor.White);
        ColorTypeWrite("• Up-to-date threat awareness\n", ConsoleColor.White);
        ColorTypeWrite("• Practical protection strategies\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();
    }

    static void DisplayFarewell(string userName)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n┌──────────────────────────────────────────────┐");
        Console.WriteLine("│                 STAY CYBER SAFE               │");
        Console.WriteLine("├──────────────────────────────────────────────┤");
        Console.ResetColor();

        ColorTypeWrite($"\n👋 Goodbye, {userName}!\n", ConsoleColor.Cyan);
        ColorTypeWrite("Remember to practice what you've learned today.\n", ConsoleColor.White);
        ColorTypeWrite("Your cybersecurity is in your hands!\n\n", ConsoleColor.White);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("└──────────────────────────────────────────────┘");
        Console.ResetColor();

        Thread.Sleep(2000);
    }
}