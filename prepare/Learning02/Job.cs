using System;

//This is the class
public class Job
{
    //This is the member variables in the class for each
    //element.
    //Variables begin with an underscopre and lowercase
    //letter, such as _jobTitle.
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //The method displays the job details on the screen
    //in the correct format.
    //The method accesses the member variables directly
    //without needing them to be passed into it.
    
    //Methods begin with a capital letter, such as Display.
    //If you have multiple words, each word should be
    //capitalized, such as DisplayJobDetails.

    //I think this is the method (member function) that
    //displays the job details.      
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}