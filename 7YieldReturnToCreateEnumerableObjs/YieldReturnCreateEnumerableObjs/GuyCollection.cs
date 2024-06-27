// Ignore Spelling: Objs
namespace YieldReturnCreateEnumerableObjs
{
    /// <summary>
    /// Represents a collection of Guy objects.
    /// </summary>
    public class GuyCollection : IEnumerable<Guy>
    {
        // Static generic dictionary to store names and ages of guys.
        private static readonly Dictionary<string, int> namesAndAges = new()
        {
            /* The enumerator uses this private Dictionary
            to keep track of the guys it’ll create, but
            it doesn’t actually create the Guy objects
            themselves until its enumerator is used. */
            {"Joe", 41},
            {"Bob", 43},
            {"Ed", 39},
            {"Larry", 44},
            {"Fred", 45}
        };

        /// <summary>
        /// Returns an enumerator that creates Guy objects with random cash amounts.
        /// </summary>
        /// <returns>An IEnumerator of Guy objects.</returns>
        public IEnumerator<Guy> GetEnumerator()
        {
            Random rand = new();

            int pileOfCash = 125 * namesAndAges.Count;

            int count = 0;

            foreach (string name in namesAndAges.Keys)
            {
                /* It creates Guy objects with random amounts of cash. We’re just doing this to show
                that the enumerator can create objects on the fly during a foreach loop. */
                int cashForGuy = (++count < namesAndAges.Count) ? rand.Next(125) : pileOfCash;
                pileOfCash -= cashForGuy;
                yield return new Guy(name, namesAndAges[name], cashForGuy);
            }
        }

        // Explicit implementation of the non-generic IEnumerable interface.
        System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets or sets the age of a guy by name.
        /// </summary>
        /// <param name="name">The name of the guy.</param>
        /// <returns>The age of the guy with the given name.</returns>
        public int this[string name]
        {
            get
            {
                if (namesAndAges.ContainsKey(name))
                    return namesAndAges[name];
                /* When an invalid index is passed to
                an indexer, it typically throws an
                IndexOutOfRangeException. */
                throw new KeyNotFoundException("Name " + name + " was not found");
            }

            // This indexer has a set accessor that updates a guy's age or adds a new guy to the Dictionary.
            set
            {
                if (namesAndAges.ContainsKey(name))
                    namesAndAges[name] = value;
                else
                    namesAndAges.Add(name, value);
            }
        }
    }
}
