// contains fundamental classes for basic system operations
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        // storing choices inside an array as strings
        string[] choices = { "rock", "paper", "scissors" };

        // creating an of 'Random' class to generate random choices
        Random random = new Random();
        // variable of type string computerChoice, selects random element from choices array & assigns it to the variable
        string computerChoice = choices[random.Next(choices.Length)];
        Console.WriteLine($"Choose rock, paper, or scissors:");

        // variable of type string userChoice, will read input from the user & convert string to lowercase
        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine($"Computer chose {computerChoice}");

        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }

        // else if condition will check both inputs using "||" OR logical operator that returns true on conditions
        else if (userChoice == "rock" && computerChoice == "scissors" ||
                (userChoice == "scissors" && computerChoice == "paper") ||
                (userChoice == "paper" && computerChoice == "rock"))

        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }

    }

}
