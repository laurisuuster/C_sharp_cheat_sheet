// Has Classes with functions inside. No need to use System
using System;
// Visual Studio/Tools/Options/to customize the IDE

// Define the namespace 

namespace ConsoleApp1
{

    public class Program
    {
        // static - function can run without previously creating an object
        // void - function do not return any values after being executed
        // string[] - array that contains data inside it

        static void Main(string[] args)
        {
            // COMMON CONSOLE METHODS

            // Change the text color
            Console.ForegroundColor = ConsoleColor.White;

            // Change the Background color of the text
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            // Apply background color to the entire window
            Console.Clear();

            // Oblicatory write to the terminal
            Console.WriteLine("Hi Mum! Look I'm programming!");

            // User Interaction via input
            Console.Write("Where do you live?");

            // Store the text in a string variable
            string location = Console.ReadLine();

            // Use the answer to print out the response to the terminal 
            // $ dollar sign allows values to be directly inserted
            Console.WriteLine($"{location} is a fun place ");

            // DATA TYPES AKA VALUE TYPES

            // Boolean data type that can be either true or false
            bool canIVote = true;

            // Integral numeric types support arithmetic, bitwise logical, comparison, and equality operators.
            // Smallest integer value
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // Biggest integer value
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);

            // Long (long integer) variables are stored as signed 32-bit (4-byte) numbers ranging in value from -2,147,483,648 to 2,147,483,647.
            // Smallest integer value
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // Biggest integer value
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);

            // Decimal variables are stored as 96-bit (12-byte) unsigned integers, together with a scaling factor
            // At this time, the Decimal data type can only be used within a Variant; that is, you cannot declare a variable to be of type Decimal.

            decimal decPiVal = 3.14159265358979323846264338327950288419716939937M;
            decimal decRandoBigNum = 8.1483940582743040846264338327950288419716939937M;
            Console.WriteLine("28 digit accuracy if PI + decRandoBigNum = {0}", decPiVal + decRandoBigNum);

            // Smallest decimal value
            Console.WriteLine("Smallest decimal: {0}", decimal.MinValue);

            // Biggest  decimal value
            Console.WriteLine("Biggest decimal : {0}", decimal.MaxValue);

            // Double data type that holds double-precision floating-point numbers as 64-bit numbers in the range -1.79769313486231E308 to -4.94065645841247E-324
            //The number sign (#) type-declaration character represents the Double in Visual Basic

            // Largest double value 
            Console.WriteLine("Biggest double: {0}", double.MaxValue);

            // Smallest double value 
            Console.WriteLine("Smallest double: {0}", double.MinValue);

            // Accuracy of the double data type
            double dblPiVal = 3.14159265358979323846264338327950288419716939937;
            double dblRandoBigNum = 8.100000000000000000000000000000000000000000007;

            Console.WriteLine("Accuracy if Pi + dblRandoBigNum = {0}", dblPiVal + dblRandoBigNum);

            // The float type can represent values ranging from approximately 1.5 × 10⁻⁴⁵ to 3.4 × 10³⁸ with a precision of 7 digits.

            // Largest float value 
            Console.WriteLine("Biggest float: {0}", float.MaxValue);

            // Smallest float value 
            Console.WriteLine("Smallest float: {0}", float.MinValue);

            // Accuracy of the float data type
            float fltPiVal = 3.14159265358979323846264338327950288419716939937F;
            float fltRandoBigNum = 8.100000000000000000000000000000000000000000007F;

            Console.WriteLine("Accuracy if Pi + fltRandoBigNum = {0}", fltPiVal + fltRandoBigNum);

            // CASTING AND DATA TYPE CONVERSIONS

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            string strVal = dblFromStr.ToString();

            Console.WriteLine($"Data type : {strVal.GetType()}");

            double dblNum = 12.345;
            Console.WriteLine($"Integer : {(int)dblNum}");

            //FORMATING OUTPUT

            // Formats as currency 
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeros
            Console.WriteLine("Pad with zeros : {0:d4}", 23);

            // Limit to three decimal places
            Console.WriteLine("3 decimals : {0:f3}", 23.7836782768);

            // Commas
            Console.WriteLine("Commas: {0:n4}", 2378);

            // STRING FUNCTIONS
            string randString = "A string is a sequential collection of characters that's used to represent text.";

            // Find the number of characters in a string 
            Console.WriteLine("String Lenght : {0}", randString.Length);

            // Check whether string contains another string
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));

            // Retrive the index if string is found
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));

            // Remove number of characters starting from specific index
            Console.WriteLine("Remove string : {0}", randString.Remove(10, 6));

            // Add a string starting from specific index
            Console.WriteLine("Insert string : {0}", randString.Insert(9, "extra spicy "));

            // Replace a string inside string
            Console.WriteLine("Replace string : {0}", randString.Replace("sequential", "consecutive"));

            // Compare strings, ignore case 
            // OrdinalIgnoreCase property treats the characters in the strings to compare as if they were converted to uppercase using the conventions of the invariant culture
            Console.WriteLine("Compare X to Y: {0}", String.Compare("X", "Y", StringComparison.OrdinalIgnoreCase));

            // Equals(Object) Determines whether the specified object is equal to the current object.
            // Equals(Object, Object) Determines whether the specified object instances are considered equal.
            Console.WriteLine("A = a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length.
            Console.WriteLine("Pad Right is : {0}", randString.PadRight(20, '.'));

            // Returns a new string that right-aligns the characters in this instance by padding them with spaces on the left, for a specified total length.
            Console.WriteLine("Pad Left is : {0}", randString.PadLeft(20, '.'));

            // Removes all leading and trailing white-space characters from the current string.
            Console.WriteLine("Trim : {0}", randString.Trim());

            // Converts the value of a Unicode character to its uppercase equivalent.
            Console.WriteLine("Uppercase: {0}", randString.ToUpper());

            // Converts the value of a Unicode character to its lowercase equivalent.
            Console.WriteLine("Lowercase: {0}", randString.ToLower());

            //Use format to create strig
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paua", "Pukekohe", "Fishing", "Adventure park");

            //Escape characters 
            // The sequence \"  inserts a double quote in a string:
            string escapeString1 = "We are the so-called \"Vikings\" from the north.";


            // ARRAY
            //Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
            // Array of integers
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Array of strings
            string[] cars = { "ranger", "hilux", "d-max" };

            // Var to create array - values must be on the same type. 
            var employees = new[] { "John", "Markus", "Jackson" };

            // Object to create array - values can be on the different data type. 
            object[] randoArray = { "Paul", 666, 3.146 };

            // Gets the Type of the current instance.
            Console.WriteLine("randoArray 0 : {0}", randoArray.GetType());

            // Gets the Lenght of the current instance.
            Console.WriteLine("randoArray 0 : {0}", randoArray.Length);

            // FOR LOOP 
            for (int j = 0; j < randoArray.Length; j++)
            {
                Console.WriteLine("Array : {0} : Value {1} ", j, randoArray[j]);
            }






        } // String args 
    } // Public class
} // namespace