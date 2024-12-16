using System.Security.Cryptography.X509Certificates;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me permission level");
            string permission = Console.ReadLine();
            int level;
            string levelString;

            do
            {
                Console.WriteLine("Please insert your level :");
                levelString = Console.ReadLine();
            }
            while (!int.TryParse(levelString, out level));
               

            WelcomeMethod(permission, level);


            void WelcomeMethod(string permission, int lvl)
            {
                if (permission.Contains("Admin"))
                {
                    if (lvl > 55)
                        Console.WriteLine("Welcome, Super Admin user");
                    else
                        Console.WriteLine("Welcome, Admin user");
                }
                else if (permission.Contains("Manager"))
                {
                    if (lvl > 20)
                        Console.WriteLine("Contact an Admin for access.");
                    else
                        Console.WriteLine("You do not have sufficient privileges.");
                }
                else
                    Console.WriteLine("You do not have sufficient privileges.");



            }
        }
    }
}
