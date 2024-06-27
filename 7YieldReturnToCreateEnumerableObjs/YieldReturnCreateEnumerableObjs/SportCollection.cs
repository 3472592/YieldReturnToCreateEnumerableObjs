// Ignore Spelling: Objs
namespace YieldReturnCreateEnumerableObjs
{
    // Represents a collection of sports.
    public class SportCollection : IEnumerable<Sport>
    {
        // Explicitly implement the non-generic IEnumerable interface.
        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Returns an enumerator that yields the Sport values.
        public IEnumerator<Sport> GetEnumerator()
        {
            // Calculate the maximum enum value for Sport.
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;

            // Yield each Sport value in the enumeration.
            for (int i = 0; i <= maxEnumValue; i++)
                yield return (Sport)i;
        }

        // Returns an IEnumerable of string names.
        public IEnumerable<string> NameEnumerator()
        {
            yield return "Bob";    // The method exits after this statement ...
            yield return "Harry";  // ... and resumes here the next time through
            yield return "Joe";
            yield return "Frank";

            IEnumerable<string> names = NameEnumerator(); // Put a breakpoint here
            foreach (string name in names)
                Console.WriteLine(name);
        }

        // Indexer for the SportCollection class.
        // Passing an index will return the corresponding Sport enum value.
        public Sport this[int index]
        {
            get
            {
                return (Sport)index;
            }
        }
    }
}
