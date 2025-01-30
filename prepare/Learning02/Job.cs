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

    //I think this is the method (member function) that
    //displays the job details.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}