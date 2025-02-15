using System;
using System.Diagnostics.CodeAnalysis;
//using System.Collections.Generic;

//This was in our lesson, but I don't know if I was supposed
//to put it on here. It aleady had the other two system codes.


//What is "new" and why do we need it?

//It turns out that List is a class or 
//custom data type and we are creating 
//a new object or instance of that class. 
//This is actually the complete focus of 
//this course, and beginning next week 
//you will learn how to create your very 
//own custom classes.

//With this in mind, you will learn much 
//more about this in coming weeks, but for 
//now, just remember to include new before 
//you start using a list.
//args is short for arguments i.e. the values
//that the function or method expects to have passed it.
//static means that the method belongs to the Program
//class and not an object of the Program class.
//void means that the method does not have a
//return value.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
            //Parse converts the string representation of a
            //number in a specified culture-specific format
            //to its 32-bit signed integer equivalent.

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        //to get the size of the list, use the Count property
        //properties don't need parentheses
        //functions need parentheses()

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        //the foreach loop iterates through a list in C#

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}

//accessing the items by their index example:
//for (int i = 0; i < numbers.Count; i++)
//{
//      Console.WriteLine(numbers[i]);
//}