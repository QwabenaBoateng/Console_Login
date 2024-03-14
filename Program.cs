using System;

// Entry point of the program
MckenzieLogin login = new MckenzieLogin("Welcome to the Login Page"); // Instantiating MckenzieLogin class with a greeting message
login.Start(); // Starting the login process

// Definition of the MckenzieLogin class
public sealed class MckenzieLogin
{
    public string _greeting; // Field to store the greeting message

    // Method to print a separator line
    public void PrintSeparator()
    {
        Console.WriteLine("----------------------------");
    }

    // Constructor to initialize the greeting message
    public MckenzieLogin(string greeting)
    {
        _greeting = greeting;
    }

    // Method to start the login process
    public void Start()
    {
        // Print the separator and greeting message
        PrintSeparator();
        Console.WriteLine(_greeting);
        PrintSeparator();

        // Prompt the user to enter their username
        Console.WriteLine("Enter Username:");
        string userNameInput = Console.ReadLine();
       
        // Prompt the user to enter their password
        Console.WriteLine("Enter Password:");
        string passWordInput = Console.ReadLine();

        // Prompt the user to confirm their password
        Console.WriteLine("Confirm Password:");
        string confirmPassWordInput = Console.ReadLine();

        // Check if the password and confirm password match
        if (passWordInput != confirmPassWordInput)
        {
            // Display a message if the passwords do not match
            Console.WriteLine("Wrong Password");
        }
        else
        {
            // Display a welcome message if the passwords match
            Console.WriteLine($" Welcome {userNameInput} You're Logged In");
        }
    }
}
