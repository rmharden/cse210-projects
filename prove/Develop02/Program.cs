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
///Journal Program:
///1. What does the program do?
///It creates and stores a journal.
///It gives a daily writing prompt.
///It records the response.
///It saves the date, their responses, and the question 
///to a file.
///It writes a new entry and gives them a random prompt 
///from a list that I create.
///It displays the jounral and iterates through all entries
///to display them on the screen.
///It saves the journal to a file by prompting the user
///for a filename and then saves the current journal, the
///complete list of entries, to that file location.
///It prompts the user for the filename and then loads it.
///There is a complete list of entries from that file.
///This replaces any entries currently stored in the journal.
/// It provides a menus that allows the user to choose these
/// options.
/// It has at least five different prompts and new prompts
/// that I am going to write in the program from the user.
/// The interface should be close to the pattern shown in the
/// video demo.
/// The program has to have classes for the major components.
/// It contains at least two classes in addition to the 
/// Program class.
/// It demonstrates the principle of abstraction by using
/// member variables and methods appropriately.
/// 
/// Saving your file as a .csv file requires you to handle
/// commas and quotes in the content appropriately. At this
/// point, you can ignore that and just choose a symbol for
/// a separator that you think is unlikely to show up in
/// the content (such as | or ~ or ~|~). I DO NOT KNOW WHAT
/// THIS MEANS.
/// 
/// You do not need to store the date as an actual C# 
/// DateTime object in your class or in the file. You can 
/// simply store it as a string.
/// 
/// JSON is JavaScript Object Notation. It is used for data
/// storage and transfer.
/// 
/// The program has the following user inputs:
/// 
///</summary>

///<summary>
///Prompts:
///Who was the most interesting person I interacted with today?
///What was the best part of my day?
///How did I see the hand of the Lord in my life today?
///What was the strongest emotion I felt today?
///If I had one thing I could do over today, what would it be?
///</summary>


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