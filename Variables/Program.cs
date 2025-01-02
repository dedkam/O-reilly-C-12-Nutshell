using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

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


            // String Formatting
            string first2 = "Hello";
            string second2 = "World";
            string result5 = string.Format("{0} {1}!", first2, second2);
            Console.WriteLine(result5);

            // Interpolation

            string first3 = "Hello";
            string second3 = "World";
            Console.WriteLine($"{first3} {second3}!");
            Console.WriteLine($"{second3} {first3}!");
            Console.WriteLine($"{first3} {first3} {first3}!");

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");
            //:C currency format specifier is used to present the price and discount variables as currency. 


            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units"); // Measurement: 123,456.79 units
            // By default, the N numeric format specifier displays only two digits after the decimal point.

            // formatting percentages
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            decimal price2 = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);
            yourDiscount += $"A discount of {((price2 - salePrice) / price2):P2}!"; 

            Console.WriteLine(yourDiscount);

            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total5 = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"\tProduct Shares: {productShares:N3}");
            Console.WriteLine($"\tSubtotal: {subtotal:C}");
            Console.WriteLine($"\tTax Percentage: {taxPercentage:P2}");
            Console.WriteLine($"\tTotal: {total5:C}");


            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12));
            Console.WriteLine(input.PadLeft(12, '-')); //  ----Pad this
            Console.WriteLine(input.PadRight(12, '-'));//  Pad this----

            string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);
            
            Console.WriteLine(formattedLine);
            Console.WriteLine("1234567890123456789012345678901234567890");

            //Exercise
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n");
            Console.WriteLine($"Currently, you own {currentShares:C} shares at a return of {currentProfit:P2}");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage += currentProduct.PadRight(16);
            comparisonMessage += $"{currentReturn:P2}".PadRight(8);
            comparisonMessage += $"{currentProfit:C}";
            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(16);
            comparisonMessage += $"{newReturn:P2}".PadRight(8);
            comparisonMessage += $"{newProfit:C}";

            Console.WriteLine(comparisonMessage);

            string message5 = "Find what is (inside the parentheses)";

            int openingPosition = message5.IndexOf('(');
            int closingPosition = message5.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            Console.WriteLine(message5.Substring(openingPosition, closingPosition-openingPosition));

            const string input3 = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            int quantityStart = input3.IndexOf("<span>") + "<span>".Length;
            int quantityEnd = input3.IndexOf("</span>");

            int outputStart = input3.IndexOf("<div>") + "<div>".Length;
            int outputEnd = input3.IndexOf("</div>");
            string quantity = input3.Substring(quantityStart, quantityEnd - quantityStart);
            string output = input3.Substring(outputStart, outputEnd-outputStart);

            // Your work here

            Console.WriteLine(quantity);
            Console.WriteLine(output);

        }
    }
}
