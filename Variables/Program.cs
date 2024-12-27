using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            int[] data;     //it is not pointing to a memory address - so it's called null reference
            data = new int[3];  //create an instance of int array - .NET runtime compiles and returns a memory address

            int[] data2 = new int[3];

            // string is also reference type but no need to add 'new' operator
            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);

            // CASTING
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal1 = myInt;
            Console.WriteLine($"decimal: {myDecimal1}");

            decimal myDecimal2 = 3.14m;
            Console.WriteLine($"decimal: {myDecimal2}");

            int myInt2 = (int)myDecimal2;
            Console.WriteLine($"int: {myInt2}");

            // narrowing conversion - loosing precision 
            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float  : {myFloat}");

            // ToString() method
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message); // 57

            // Parse() method
            string third = "5";
            string fourth = "6";
            int sum = int.Parse(third) + int.Parse(fourth);
            Console.WriteLine($"Sum =  {int.Parse(third) + int.Parse(fourth)}");
            
            // Convert
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            // casting vs converting
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value); // 1

            int value5 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value5); // 2

            // TryParse
            string value3 = "102";
            string value4 = "UcY++6pwr+.XuCp";
            int result2 = 0;
            if (int.TryParse(value3, out result2))
            {
                Console.WriteLine($"Measurement: {result2}");
            }
            else
            {
                Console.WriteLine("Unable to parse string value");
            }

            // Casting 

            string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string messageToDisplay = string.Empty;
            foreach (string v in values)
            {
                decimal number;
                if (decimal.TryParse(v, out number))
                {
                    total += number;
                }
                else
                {
                    messageToDisplay += v;
                }
            }
            Console.WriteLine($"Message: {messageToDisplay}");
            Console.WriteLine(@"Total: {0}", total);


            int value11 = 11;
            decimal value22 = 6.2m;
            float value33 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            int result11 = Convert.ToInt32(value11 / value22);
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result11}");

            // Your code here to set result2
            decimal result22 = value22 / (decimal)value33;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result22}");

            // Your code here to set result3
            float result33 = value33 / value11;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result33}");


            //SUMMARY
            // You used implicit conversion, relying on the C# compiler to perform widening conversions. When the compiler was unable to perform an implicit conversion,
            // you used explicit conversions. You used the ToString() method to explicitly convert a numeric data type into a string.
            // When you needed to perform narrowing conversions, you used several different techniques.You used the casting operator () when the conversion could be
            // made safely and were willing to accept truncation of values after the decimal. And you used the Convert() method when you wanted to perform a conversion
            // and use common rounding rules when performing a narrowing conversion.
            // Finally, you used the TryParse() methods when the conversion from a string to a numeric data type could potentially result in a data type conversion exception.
        }
    }
}
