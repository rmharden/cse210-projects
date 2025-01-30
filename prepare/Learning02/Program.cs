using System;
using System.IO.Pipes;
//using System.Threading.Tasks.Dataflow;

//Abstraction is the process of turning complex ideas into
//simple ones. It is removing characteristics from something
//so that only the essential ones remain.

//the print("hello world") code is an abstraction of 3000
//lines of C to implement the function.

//The print function is an abstraction. It is a simplification
//of something that is quite complex.

//Layering abstractions is how all software is written.

//Objects and Classes

//Classes are a way of creating abstractions in software.

//An object is a conceptual model for a category of things,
//real or imagined, that has a specific responsibility within
//our program.

//Objects have state and behavior that allow them to fulfill
//their responsibility.

//With an object in mind, we are ready to translate it to a
//code template called a class.

//The object's state is translated to variables called
//attributes.

//The object's behaviors are translated to functions called
//methods.


//Classes ad Instances
//By itself, a class is just a template for something.
//It only becomes useful when an instance is created
//and assigned to a variable in the program.

//An instance is the realization of attributes and methods
//in the computer's memory.

//Creating an instance of a class is like baking a cake.
//A class is the recipe. It's a template for the cake but
//not the actual baked cake.
//In contrast, an instance is what come out of the oven. 
//An instance is the cake and was created by the class
//or recipe.


//This is the class or name of the class
class Program
{
    static void Main(string[] args)
    {
        //The Job class is in a new file called Job.cs

        //An instance of the Job class is created and
        //assigned to the variable called "job1".
        //It is created by invoking a special method,
        //called the constructor, which is the name
        //of the class followed by parentheses.
        //C# requires the word "new" keyword when
        //calling a constructor.
        Job job1 = new Job();
        //the member variables start with a underscore _
        job1._jobTitle = "Software Enigeer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //One of the most important aspects of programming
        //with classes is that multiple instances can be
        //created and used in the same program.
        //An instance of the Job class is created and
        //now is assigned to the variable "job2".
        //It is created by invoking the constructor method
        //which is the name of the class followed by
        //parenthenses and it requires the keyword "new".
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
/// <summary>
/// When you create classes, you are really creating a new
/// custom data type.
/// In C# there are built-in data types for integers and
/// strings.
/// When you declare a variable of these types, it is like
/// making a box that can hold that type of data, and putting
/// a label on the outside of the box with the variable name.
/// EXAMPLE:  int height;
/// EXAMPLE:  string color;
/// The code creates boxes that you can later fill with values.
/// Then when you assign the value, it puts it in the box.
/// EXAMPLE:   height = 17;
/// This puts the number 17 in the height box.
/// EXAMPLE:   height = 24;
/// This code changes the number in the height box to 24.
/// 
/// EXAMPLE:
/// 
/// public class Blind
/// {
///     public double _width;
///     public double _height;
///     public string _color;
/// }
/// 
/// This makes a box called blind with three boxes inside,
/// labeled _width, _height, and _color.
/// 
/// Every time you create a new Blind variable, it creates a
/// large box that has these three components.
/// The class is what defines the structure of the large box,
/// and each of these large boxes that you create is an object
/// or instance of that class.
/// 
/// Blind kitchen = new Blind();
/// 
/// In this code, whenever you use the variable kitchen it
/// refers to a large box, and if you want to refer to
/// anything inside the box, you use the "dot" operator.
/// You can set the values as follows:
/// 
/// kitchen._width = 60;
/// kitchen._height = 48;
/// kitchen._color = "white";
/// 
/// This code accesses the values:
/// 
/// Console.WriteLine(kitche.width);
/// 
/// Sorting all these values together in one larger box
/// simplifies your code.
/// You can now pass that whole large box to a function as
/// a parameter, or return it.
/// 
/// Adding Behaviors
/// In addition to storing values together that belong
/// together, you can also put the member functions, or 
/// methods, that use that data right in the box with them.
/// 
/// This code will compute the area of the blind so the
/// program could display the amount of material you
/// needed.
/// 
/// It can be added as a function inside the box, called
/// GetArea().
/// 
/// public class Blond
/// {
///     public double _width;
///     public double _height;
///     public string _color;
///     
///     public double GetArea()
///     {
///         return _width * _height;
///     }
/// }
/// 
/// The GetArea() function now belongs inside the box as well.
/// Because it's inside the box, you now use the "dot"
/// notation to call it.
/// 
/// To call the GetArea() method,
/// you must supply the name of the object first, followed by
/// a dot. The name of the object is "kitchen".
/// You also don't need to pass it variables for the width
/// and the height.
/// This is because the method is a member of the class,
/// so it is already "in the box," so it can access any
/// of the member variable it needs.
/// 
/// The fact that the method accesses the member variables in
/// its box is also why the GetArea() will return different
/// values for different Blind objects, such as
/// kitchen.GetArea() and livingRoom.GetArea(), because these
/// two objects will ahve different values for their widths
/// and heights.
/// 
/// double materialAmount = kitchen.GetArea();
/// 
/// 
/// This code shows all of these lines together:
/// 
/// Blind kitchen = new Blind();
/// 
/// kitchen._width = 60;
/// kitchen._height = 48;
/// kitchen._color = "White";
/// 
/// double materialAmount = kitchen.GetArea();
/// 
/// </summary>
