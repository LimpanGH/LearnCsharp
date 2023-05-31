

// See https://aka.ms/new-console-template for more information
using Internal;
using System;

Console.WriteLine("Hello, World!");


using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

/* capitalize: will turn lowercase characters into uppercase characters
square: will square a number
evaluate: will determine if an input is true or false
The data types include:

int -       whole numbers, like: 1, -56, 948
double -    decimal numbers, like: 239.43909, -660.01
char -      single characters, like: “a”, “&”, “£”
string -    string of characters, like: “dog”, “hello world”
bool -      boolean values, like: true or false */


// There are two ways we can assign variables. We can do it on two lines:

// Declare an integer
int myAge;
myAge = 32;

// Or, we can be more concise and just do it on one:
// Declare a string
string countryName = "Netherlands";

/* In each case, we first write the data type, then the variable name, then use the equals
sign = to assign the variable a value. */



/* Converting Data Types ----------------------------------

C# checks to make sure that when we convert data types from one to another that we’re not losing any data, 
 because that could cause problems in our code.

Because of that, there are a couple different ways to do data type conversion:

Implicit conversion: happens automatically if no data will be lost in the conversion.
That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.

Explicit conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int,
we could use the operator (int).
So, if we’re to fix the error in our previous code, we’d rewrite it as follows:

double myDouble = 3.2; 
// Round myDouble to the nearest whole number
int myInt = (int)myDouble;

It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method,
like:

Convert.ToString() and
Convert.ToDouble().

For a full list of Convert class built-in methods,check out the Microsoft Documentation */

// Converting Data Types ------------ https://www.codecademy.com/courses/learn-c-sharp/lessons/csharp-data-types-variables/exercises/converting-data-types-csharp
using System;
namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // 1. Turn that answer into an int (rembember to type "dotnet run" in console to run the code)

      // 1.1 Implicit conversion, would happen automatically, (does'nt work in with string to number)

      // 1.2 Explicit conversion (does'nt work in with string to number)
      //int faveNumber = Console.ReadLine();

      // 1.3 Conversion with built-in methods.
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      // Log user favorite number.
      Console.WriteLine($"Your favorite number is {faveNumber}");
    }
  }
}

// Converting bool to string and string to char ------------------------------
using System;
namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
      

            // 1. Convert a boolean to a string
            bool isYes = true;
            string isTrue = Convert.ToString(isYes);
            Console.WriteLine(isTrue);


            // 2. Change a string to a list of chars
            {
                string greeting = "HelloWorld!";
                Char[] myArray = greeting.ToCharArray();
                foreach (char value in myArray)
                {
                    Console.WriteLine(value);
                }
            }

        }
    }
}

// Numbers ------------------------------------

using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenue = 390819.28m;  // remember to use the "m" suffix to create a literal of this type. 

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);
        }
    }
}


// Arithmatics ------------------------------

using System;

namespace BugSquasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int apple = 1;
            apple += 1;            // or apple++, apple--
            Console.WriteLine(apple);
        }
    }
}

// Modulos ---------------------------------
// Modulos are useful because they let us know if a number “fits” into a larger number, or if there will be a remainder. For example, how many eggs will be left over if I try and fit 56 eggs into crates of a dozen eggs?

int eggs = 56;
int crateAmount = 12;
int eggsLeftOver = eggs % crateAmount;
Console.Write(eggsLeftOver); // prints 8

/* It can also be used to check if a number is odd or even. If a number is even, taking its modulo with 2 it will return a 0 and
   if it is odd it will return a 1: */
int myNum = 85939824;
Console.Write(myNum % 2); // prints 0, so number is even


// There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few:

Math.Abs()      will find the absolute value of a number. Example: Math.Abs(-5) returns 5.
Math.Sqrt()     will find the square root of a number. Example: Math.Sqrt(16) returns 4.
Math.Floor()    will round the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
Math.Min()      returns the smaller of two numbers. Example: Math.Min(39, 12) returns 12.


// Use built-in methods to determine which number is smaller between the square roots of two different numbers. https://www.codecademy.com/courses/learn-c-sharp/lessons/csharp-working-with-numbers/exercises/built-in-methods-numbers-csharp
using System;
namespace LowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));

            // Use built-in methods and save to variable
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));
        }
    }
}

// Methods Math.Pow(), Math.Max() and Math.Ceiling() ---------------------------- Docs: https://learn.microsoft.com/en-us/dotnet/api/
using System;
namespace DocumentationHunt
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));
        }
    }
}
