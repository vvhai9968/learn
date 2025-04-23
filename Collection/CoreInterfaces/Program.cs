namespace CoreInterfaces;

class Program
{
    /// <summary>
    ///     IEnumerable<T>
    ///         ▲
    ///         │
    ///     ICollection<T> : IEnumerable<T>
    ///         ▲
    ///         │
    ///     IList<T> : ICollection<T>, IEnumerable<T>
    
    
    /// ******************** IQueryable<T> ********************
    /// Real use case: You're working with entity framework or any LINQ provider that supports translation to backend queries.
    /// Definition: used for querying data from external sources like data using LINQ(i.n., Entity Framework)
    ///
    /// ------------------ Advantages ------------------
    ///  Deferred execution: Queries are only executed when the data is iterated, allowing for query composition
    ///  Efficient for remote queries: translates LINQ queries into SQL (with Entity Framework), minimizing data loaded into memory
    ///  Supports LINQ enables powerful filtering, sorting, projection, etc.
    ///
    /// ------------------ Disadvantages ------------------
    ///  Slower for In-Memory data: not meant for collections in memory -- IEnumerable is better there 
    ///  No Built-in Modification Support: It is a read-only query interface no Add, Remove, etc. 
    ///  Can Cause Runtime Errors: Complex queries might not translate properly to SQL, causing runtime exceptions
    
   
    /// ******************** IEnumerable<T> ********************
    /// Real use case: You're building a reporting system where the service just reads a list of records but doesn't modify it 
    /// Purpose: represents a forward-only cursor to iterate over a collection (e.g., using foreach)
    /// 
    /// ------------------ Advantages ------------------
    /// + lazy evaluation: great for deferred execution (especially with LINQ)
    /// + simple: easy to use for read-only access
    /// + supported by LINQ: most LINQ operations return IEnumerable
    ///
    /// ------------------ Disadvantages ------------------
    /// + Read-only: No built-in methods to modify the collection
    /// + No count or indexing: Can't get the count directly or access items by index 
    /// + Not optimized for performance in repeated iterations (e.g., re-evaluates queries each time unless cached).
    
   
    /// ******************** ICollection<T> ********************
    /// Real use case: You're creating a DTO (Data transfer object) that returns a list of items where the caller can modify the collection but indexing isn't needed
    /// Definition: a general-purpose interface for collections base for IList<T> and IDictionary<Tkey, TValue>
    /// Purpose: Base interface for read/write collections adds methods to modify the collection
    ///
    /// ------------------ Advantages ------------------
    /// + Add, Remove, Clear methods: supports collection manipulation
    /// + count property: Efficient access to item count
    /// + More general than IList: used when you don't need indexing
    ///
    /// ------------------ Disadvantages ------------------
    /// + No indexing: Can't access elements by index
    /// + Less commonly used directly: often used as a base in libraries
     
   
    /// ******************** IList<T> ********************
    /// Real use case: You're building a shopping cart where item order matters and you need to insert/remove at specific positions 
    /// Purpose: Represents an ordered collection with index-based access
    ///
    /// ------------------ Advantages ------------------
    /// + Indexing: can use list[0] to access or assign 
    /// + Insert/remove at position: Useful when order matters
    /// + Full collection operations: Inherits form ICollection
    ///
    /// ------------------ Disadvantages ------------------
    /// + Performance overhead (depending on implementation like List<T> vs LinkedList<T>)  
    /// + Not always necessary: use only when you need ordering/indexing
   
   
    /// ******************** IDictionary<TKey, TValue> ********************
    /// Real use case: You're building a configuration object, where each setting is key-based.
    /// Purpose : Represents a key-value collection, like a dictionary or map
    ///
    /// ------------------ Advantages ------------------
    /// + Fast lookups by key: O(1) access time with Dictionary<TKey, Tvalue>
    /// + Flexible: Keys and values can be any types   
    /// + Ideal for lookups, caching, grouping
    /// 
    /// ------------------ Disadvantages ------------------
    /// + No ordering (unless you use SortedDictionary or OrderedDictionary)
    /// + Key must be unique: throws error if you add duplicate keys
    /// + Slightly more complex: Compared to simple lists or arrays
    /// </summary>
    
    static void Main()
    {
        // ===== 1. IQueryable<T> Example =====
        Console.WriteLine("=== IQueryable<T> Example ===");

        List<User> usersInMemory =
        [
            new User() { Id = 1, Name = "Alice", IsActive = true },
            new User() { Id = 2, Name = "Bob", IsActive = false },
            new User() { Id = 3, Name = "Charlie", IsActive = true }
        ];

        var queryableUsers = usersInMemory.AsQueryable(); // Simulate EF DbSet
        var activeUsersQuery = queryableUsers.Where(u => u.IsActive); // Deferred

        Console.WriteLine("Active users (query not executed yet).");

        foreach (var user in activeUsersQuery)
        {
            Console.WriteLine($"User: {user.Name}");
        }

        // ===== 2. ICollection<T> Example =====
        Console.WriteLine("\n=== ICollection<T> Example ===");

        ICollection<string> fruits = new List<string> { "Apple", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        foreach (var fruit in fruits)
        {
            Console.WriteLine($"Fruit: {fruit}");
        }

        // ===== 3. IList<T> Example =====
        Console.WriteLine("\n=== IList<T> Example ===");

        IList<int> numbers = new List<int> { 10, 20, 30 };
        
        numbers.Insert(1, 15); // Insert at index 1
        numbers[2] = 25;       // Replace value at index 2

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"Number at index {i}: {numbers[i]}");
        }

        // ===== 4. IDictionary<TKey, TValue> Example =====
        Console.WriteLine("\n=== IDictionary<TKey, TValue> Example ===");

        IDictionary<int, string> userDictionary = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" }
        };

        userDictionary[3] = "Charlie"; // Add new key-value
        userDictionary.Remove(2);      // Remove key 2

        foreach (var pair in userDictionary)
        {
            Console.WriteLine($"User ID: {pair.Key}, Name: {pair.Value}");
        }
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}