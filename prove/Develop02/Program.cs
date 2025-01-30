using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string option = Console.ReadLine();

        Console.WriteLine($"Thank you. Your choice was {option}.");
    }
}

///<summary>
///
///NOTES:
///From the Rubric:
///
/// Principle: Journal Abstraction
/// A class models the responsibilities of a Journal and does
/// not include items that do not pertain to a Journal
/// 
/// Principle: Entry Abstraction
/// A class models the responsibilities of an Entry and
/// does not include itesm that do not pertain to an Entry.
/// 
/// Functionality: Journal Display
/// All journal entries can be displayed along with the date
/// and prompt associated with that entry.
/// 
/// Functionality: Prompt Generation
/// A set of writing prompts is chosen from random and
/// displayed.
/// 
/// Functionality: Saving
/// The journal can be saved to a file.
/// 
/// Functionality: Loading
/// The journal can be loaded from a file.
/// 
/// Style: Whitespace
/// Vertical and horizontal whitespace (black lines and 
/// indentation) is correct throughout the program.
/// 
/// Style: Naming Conventions
/// Classes and methods use TitleCase. Attributes begin
/// with an underscore and use _camelCase.
/// 
/// Shows creativity and exceeds core requirements
/// The program exceeds the core requirements as explained
/// in comments in the Program.cs,
/// 
///</summary>