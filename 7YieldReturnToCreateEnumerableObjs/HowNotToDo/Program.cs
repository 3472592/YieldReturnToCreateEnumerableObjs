#pragma warning disable VSSpell001 // Spell Check
namespace YieldReturnCreateEnumerableObjs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            Console.WriteLine("Sport collection contents:");
            SportCollection sportCollection = new();
            foreach (Sport sport in sportCollection)
                Console.WriteLine(sport.ToString());
            Console.ReadKey();
        }
    }
}
