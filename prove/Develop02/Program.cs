using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        entry1.newEntry = "";

        entry1._entryResponse = "";
        entry1._entryPrompt = "";
        entry1._entryDate = "";

        Entry entry2 = new Entry();
        entry2.newEntry = "";

        entry2._entryResponse = "";
        entry2._entryPrompt = "";
        entry2._entryDate = "";

        Journal myJournal = new Journal();

        myJournal.entrys.Add(entry1);
        myJournal.entrys.Add(entry2);

        myJournal.Display();
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