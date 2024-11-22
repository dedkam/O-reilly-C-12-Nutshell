using Animals;
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
