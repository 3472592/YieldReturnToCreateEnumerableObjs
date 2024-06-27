// Ignore Spelling: Objs
namespace YieldReturnCreateEnumerableObjs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of the GuyCollection class.
            GuyCollection guyCollection = new();

            // Check if the command-line arguments array is null and throw an exception if it is.
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            // Display the contents of the SportCollection.
            Console.WriteLine("Sport collection contents:");
            SportCollection sportCollection = new();
            foreach (Sport sport in sportCollection)
                Console.WriteLine(sport.ToString());

            // Add two guys to the guyCollection and modify one guy's age.
            guyCollection["Bob"] = guyCollection["Joe"] + 3; // Modify Bob's age based on Joe's age.
            guyCollection["Bill"] = 57; // Add a new guy named Bill with age 57.
            guyCollection["Harry"] = 31; // Add a new guy named Harry with age 31.

            // Display the contents of the guyCollection.
            Console.WriteLine("Adding two guys and modifying one guy:");
            foreach (Guy guy in guyCollection)
                Console.WriteLine(guy.ToString());

            // Wait for a key press before exiting.
            Console.ReadKey();
        }
    }
}