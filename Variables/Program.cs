using System.Diagnostics.CodeAnalysis;

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

        }
    }
}
