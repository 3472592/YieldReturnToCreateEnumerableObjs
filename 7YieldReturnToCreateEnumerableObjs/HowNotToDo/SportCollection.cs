#pragma warning disable VSSpell001 // Spell Check
namespace YieldReturnCreateEnumerableObjs
{
    public class SportCollection : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }

        // IEnumerable contains 1(); GetEnumerator();
        // this is class for enumerator it returns.
        System.Collections.IEnumerator 
        System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // enumerator implements IEnumerable<Sport>.
        // foreach loop uses its Current property & MoveNExt() method.
        public class ManualSportEnumerator : IEnumerator<Sport>
        {
            int current = -1;
            public Sport Current 
            {
                get 
                {
                    return (Sport)current; 
                } 
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }


            object System.Collections.IEnumerator.Current 
            {
                get 
                {
                    return Current; 
                }
            }
            public bool MoveNext()
            {
                int maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
                // MoveNext() method increments current &
                // uses it to return next sport in enum.
                if (current >= maxEnumValue)
                    return false;
                current++;
                return true;
            }
            public void Reset() 
            {
                current = 0; 
            }
        }
    }
}
