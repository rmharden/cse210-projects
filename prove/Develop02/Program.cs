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
/// 2. The program has the following outputs for user inputs:
/// Please select one of the following choices:
/// 1. Write
/// 2. Display
/// 3. Load
/// 4. Save
/// 5. Quit
/// What would you like to do?
/// 
/// "1. Write" or "1" gives a random prompt for the user
/// to answer a question as their entry.
/// It shows the writing prompt on one line and the next line
/// has a ">".
/// 
/// "3. Load" or "3" asks the user "What is the filename?"
/// on one line and then the user can type the filename on
/// the next line.
/// 
/// It then asks, "What would you like to do?" - This seems
/// like a loop for a user input.
/// 
/// "4. Save" or "4" will prompt the user with "What is the
/// file name?" and the user can type it on the next line.
/// 
/// 3. What output does it produce?
/// The output is WriteLine, I think, and will look like this:
/// Welcome to the Journal Program!
/// Please select one of the following choices:
/// 1. Write
/// 2: Display
/// 3. Load
/// 4. Save
/// 5. Quit
/// What would you like to do? 
/// 
/// With 1. Write, the output will be one of the writing
/// prompts on one line and a ">" on the second line.
/// When the user presses ENTER (I think) it should call
/// the menu class again with:
/// Please select one of the following choices:
/// 1. Write
/// 2. Display
/// 3. Load
/// 4. Save
/// 5. Quit
/// What would you like to do?
/// 
/// "2. Display" or "2" will show in this order:
/// Date: with the user's inputed date - Prompt: the random
/// question
/// The user's entry.
/// 
/// It brings up the menu class loop again.
/// 
/// "3. Load" or "3" will 
/// What is the filename.
/// 
/// It will have a blank line to write the input.
/// 
/// 
/// "4. Save" or "4" has an output of 
/// What is the filename.
/// 
/// It will have a blank line to write the input.
/// 
/// 
/// 4. The program ends when the user types "5".
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
///The classes will be:
///Journal
///Entry
///PromptGenerator
///
/// The responsibilities for each are:
/// 
/// Journal:
/// To bring up the menu loop options.
/// Prompts the user to choose an option.
/// When "1" is chosen, it calls the Entry class.
/// When "2" is chosen, it [reads?] or recalls the list[?]
/// created in the Entry class, and it displays the 
/// journal entries
/// so far.
/// When "3" is chosen, it prompts the user for the name
/// of the file to "load" or to access.
/// When "4" is chosen, it prompts the user for the name
/// of the file to "save" and saves the file.
/// When "5" is chosen, it ends the program from running.
/// "5" also stops the loop.
/// 
/// Entry:
/// Calls the PromptGeneartor class.
/// Prompts the user for the entry.
/// Stores the entry in a list[?].
/// 
/// PromptGeneartor:
/// Holds the list of the writing prompt options.
/// Chooses a random prompt from the list and displays it for
/// the user.
///</summary>

///<summary>
///
///Behaviors [methods] of each class:
///
/// Journal Class:
/// Creates the list for writing prompts.
/// Displays the menu.
/// Calls the Entry class.
/// Adds an entry.
/// Displays all the entries
/// Saves to a file.
/// Loads from a file.
/// 
/// Entry Class:
/// Calls the prompt Generator
/// Prompts the user.
/// Adds the entry.
/// Displays the entry.
/// Saves the entry.
/// Stores the data.
/// 
/// PromptGenerator Class:
/// Access the list for writing prompts.
/// Displays a random writing prompt.
/// 
///</summary>

///<summary>
///Class Attributes:
///The Journal stores the list of Entry objects
///
/// List<Entry>
/// 
/// 
/// 
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