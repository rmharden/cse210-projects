using System;

class Program
{
    static void Main(string[] args)
    {
        // This creates a blank line
        Console.WriteLine("");
        
        //Asks user what their first name is.
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        
        //Asks the user what their last name is.
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        
        // This creates a blank line
        Console.WriteLine("");
        
        //Displays the sentence with the user's name.
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

    }
}