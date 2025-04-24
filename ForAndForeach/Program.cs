namespace ForAndForeach;

public class Program
{
    /// <summary>
    /// ******************** for ********************
    /// -------------------- When to use --------------------
    /// + You know how many times you want to loop
    /// + You need the index
    /// + You may manipulate the loop (skip items, go backwards, etc.)
    ///
    /// -------------------- Advantages --------------------
    /// + You can control the loop counter (e.g., skip or reverse)
    /// + You can access the in dex easily 
    /// + Can be used to iterate a part of a collection 
    /// 
    /// -------------------- Disadvantages --------------------
    /// + Slightly more error-prone (e.g., off-by-one errors)
    /// + More code to wire 
    /// + Not ideal for collections where index isn't needed
    ///
    /// -------------------- Mechanism of operation -------------------- 
    ///  Syntax:
    ///     for (initialization; condition; increment)
    ///      {
    ///         // Code block
    ///      }
    /// 
    ///   🧠 Step-by-Step Execution:
    ///  1. Initialization happens once at the start (e.g., int i = 0;).
    ///  2. Condition is checked before each loop (e.g., i < 5).
    ///       If true -> execute loop body.
    ///       If false -> exit the loop.
    ///  3. Code Block inside the loop runs.
    ///  4. Increment/Update happens after each iteration (e.g., i++).
    ///  5. Go back to Step 2.
    ///
    /// 
    /// ********************* foreach *********************
    /// --------------------- When to use ---------------------
    /// + You want to read every time in a collection
    /// + You don't need the index 
    /// + You want cleaner, safer code
    /// 
    /// --------------------- Advantages --------------------- 
    /// + Very readable and concise
    /// + Safer - no index errors or accidental out-of-bounds access
    /// + Perfect for read-only iteration
    /// 
    /// --------------------- Disadvantages --------------------- 
    /// + You can't access the index directly
    /// + You can't modify the collection inside the loop (e.g., remove an item)
    /// + Less flexible if you need to skip or break specific iterations
    ///
    /// --------------------- Mechanism of operation ---------------------
    ///  Syntax: 
    ///     foreach (var item in collection)
    ///     {
    ///         // Code block
    ///     }
    ///  🧠 What Happens Under the Hood:
    ///   1. The compiler converts foreach into an enumerator-based loop.
    ///   2. The collection must implement IEnumerable or IEnumerable<T>.
    ///   3. Internally, it uses:
    ///       IEnumerator<T> enumerator = collection.GetEnumerator();
    ///       while (enumerator.MoveNext())
    ///       {
    ///           var item = enumerator.Current;
    ///           // Code block
    ///       }
    /// </summary>
    /// 
    static void Main()
    {
        #region for

        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8];

        for (var i = 0; i < numbers.Length; i += 2) // Skipping every second element
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine($"Even number at index {i}: {numbers[i]}");
            }
        }

        #endregion


        #region foreach

        var customers = new List<string> { "Alice", "Bob", "Charlie" };

        foreach (var customer in customers)
        {
            Console.WriteLine($"Customer: {customer}");
        }

        #endregion
    }
}