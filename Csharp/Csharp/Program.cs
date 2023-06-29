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








        }
    } 
}