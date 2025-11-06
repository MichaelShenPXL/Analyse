using System.Reflection.Metadata;

namespace analyze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "admin", password = "password123";

            int tries = 0;

            while (tries < 3)
            {
                Console.Write("geef je gebruikersnaam in: ");
                string Name = Console.ReadLine();

                Console.Write("geef nu je wachtwoord in; ");
                string wachtwoord = Console.ReadLine();



                if (Name == user && wachtwoord == password)
                {
                    Console.WriteLine($"welkom {Name} in het systeem!");
                }
                tries++;
                Console.WriteLine($"Foutieve login.\n{3 - tries} pogingen over.");

            }
            Console.WriteLine("Te veel pogingen. Toegang geweigerd.");
        }
    }
}
