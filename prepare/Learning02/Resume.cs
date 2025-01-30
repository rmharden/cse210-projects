using System;

//This is creating the Resume class.
public class Resume
{
    //This creates the member variable for the person's name.
    public string _name;

    //This creates the variable for the list of jobs.
    //List<Job> is a data type.
    //It is easiest to initialize the new list when it
    //is declared.
    public List<Job> _jobs = new List<Job>();

    //This is a Display method.
    public void Display()
    {
        //This calls and displays name and jobs
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //This iterates through the Job list and displays
        //each job, right?
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}