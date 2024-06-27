// Ignore Spelling: Objs

namespace YieldReturnCreateEnumerableObjs
{
    /// <summary>
    /// Represents a person with a name, age, and cash.
    /// </summary>
    public class Guy
    {
        // Private field to store the name of the guy.
        private readonly string _name;

        // Private field to store the age of the guy.
        private readonly int _age;

        /// <summary>
        /// Gets the name of the guy.
        /// </summary>
        protected string Name 
        { 
            get 
            { 
                return _name;
            }
        }

        /// <summary>
        /// Gets the age of the guy.
        /// </summary>
        protected int Age
        { 
            get 
            { 
                return _age; 
            } 
        }

        /// <summary>
        /// Gets or sets the amount of cash the guy has.
        /// </summary>
        public int Cash { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Guy class with a name, age, and cash.
        /// </summary>
        /// <param name="name">The name of the guy.</param>
        /// <param name="age">The age of the guy.</param>
        /// <param name="cash">The initial amount of cash the guy has.</param>
        public Guy(string name, int age, int cash)
        {
            _name = name;
            _age = age;
            Cash = cash;
        }
    }
}