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
