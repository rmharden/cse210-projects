//This activity works with Functions
//You define the functions with a name and list of
//parameters.

//The function then has a body that performs tasks
//and it can potentially return a value.

//Each function must define its return type.
//For example, it will return an int, a string, or nothing
//(the return type for nothing is void).

//Each parameter must have a data type as well. - You will
//know exactly what kind of data you are receiving.

//Function names should use "Title Case" where the name
//begins with a capital letter and then each subsequent word
//is capitalized such as: ThisIsALongFunction.

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //this is a function because of the parentheses()?
        DisplayWelcomeMessage();

        //Variables?
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    /// <summary>
    /// This is a function that does not have a single 
    /// parameter or a return type (hence the use of void:)
    /// It has "static void" instead of just "void" though.
    /// </summary>
    static void DisplayWelcomeMessage()
    {
        //DisplayWelcome - Displays the message,
        //"Welcome to the Program!"        
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        //PromptUserName - Asks for and returns user's name
        //(as a string.)
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        //PromptUserNumber - Asks for and returns the user's
        //favorite mumber (as an integer.)
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
//I think this is function that accepts an integer as a
//parameter and then multiplies that number by itself.
//The function specifies a return value of int at the
//beginning of the definition.
//Why do the functions all start with "static" and the 
//lesson's functions dont?

    static int SquareNumber(int number)
    {
        //SquareNumber - Accepts an integer as a parameter
        //and returns that numner squared (as an integer.)
        int square = number * number;
        return square;
    }
    //This is a standalone function using the keyword, static,
    //before the return type.
    static void DisplayResult(string name, int square)
    {
        //DisplayResult - Accepts the user's name and the
        //squared number and displays them.
        Console.WriteLine($"{name}, your number squared is: {square}");
    }

}

//The default case for all functions is to be methods, which
//must be called in the context of an object.
//To declare a regular standalone function, you need to use
//the static keyword. This tells C# that you want your
//functions to be able to be called without any other context.
//To define a standalone function in C#, use the keyword
//before the return type.

//Before we start writing classes, for now we are putting
//the static keyword in front of all our functions.