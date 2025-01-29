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
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

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

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

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