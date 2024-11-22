using Animals;
using System.Threading.Channels;
internal class Program
{
    private static void Main(string[] args) // Program entry point
    {
        Panda p1 = new Panda("PanDa3");
        Panda p2 = new Panda("PanDa4");

        Console.WriteLine(p1.Name);
        Console.WriteLine(p2.Name);
        Console.WriteLine(Panda.Population);

        // INFINITY VALUES
        // Dividing a nonzero number by zero results in an infinite value:
        Console.WriteLine(1.0 / 0.0);                  //  Infinity
        // Dividing zero by zero, or subtracting infinity from infinity, results in a NaN:
        Console.WriteLine(0.0 / 0.0);                  //  NaN


        // RAW STRING LITERAL c#11
        // Wrapping a string in three or more quote characters (""") creates a raw string literal.
        
        string raw = """<file path="c:\temp\test.txt"></file>""";
        Console.WriteLine(raw);
        //Multiline raw string literals
        string multiLineRaw = """
            Line 1
            Line 2
            """;

        Console.WriteLine("""
            {
              "Name" : "Joe"
            }
            """);

        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        Arrays array = new Arrays();
        array.Print(vowels);

        // INDICES
        char lastElement = vowels[^1]; // refers to the last element
        char secondToLast = vowels[^2]; // refers to the second-to-last

        // RANGES - "slice" an array by using .. operator
        char[] firstTwo = vowels[..2];    // 'a', 'e'
        char[] lastThree = vowels[2..];    // 'i', 'o', 'u'
        char[] middleOne = vowels[2..3];   // 'i'
        // The second number in the range is exclusive, so ..2 returns the elements before vowels[2].

        // Creating an array always preinitializes the elements with default values.
        // The default value for a type is the result of a bitwise zeroing of memory.
        // For example, consider creating an array of integers.
        int[] a = new int[1000];
        Console.WriteLine(a[123]); // 0

    }

    public class Arrays
    {

        
        // or
        // char[] vowels = {'a','e','i','o','u'};
        
        

        public void Print(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine("'" + charArray[i] + "'");
            }
        }
        

    }
}

namespace Animals
{
    public class Panda
    {
        public string Name; //field
        public static int Population; // static field - Data members and function members that don’t operate on the instance of the type can be marked as static

        public Panda(string n)
        {
            Name = n; // assign the instance field
            Population += 1; // increment the static population
        }
    }
}
