using System.Collections;
using System.Collections.Concurrent;

namespace GenericCollection;

public class Program
{
    static void Main()
    {
        #region Non-Generic Collections

        #region ArrayList

        ArrayList mixedList = new ArrayList();
        mixedList.Add(10); // Adding integer
        mixedList.Add("Hello"); // Adding string
        mixedList.Add(DateTime.Now); // Adding DateTime object

        Console.WriteLine("ArrayList contents:");
        foreach (var item in mixedList)
        {
            Console.WriteLine($"Item: {item}, Type: {item.GetType()}");
        }

        Console.WriteLine();

        #endregion

        #region Hashtable

        Hashtable hashtable = new Hashtable();
        hashtable.Add("Alice", 30);
        hashtable.Add("Bob", 25);
        hashtable["Charlie"] = 28; // Another way to add key-value pairs

        // Accessing values using keys
        Console.WriteLine("Hashtable contents:");
        Console.WriteLine($"Alice's age: {hashtable["Alice"]}");
        Console.WriteLine($"Bob's age: {hashtable["Bob"]}");

        // Checking if a key exists
        if (hashtable.ContainsKey("Charlie"))
            Console.WriteLine($"Charlie is in the Hashtable and is {hashtable["Charlie"]} years old.");

        // Looping through the Hashtable
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key} => {entry.Value}");
        }

        Console.WriteLine();

        #endregion

        #endregion

        #region Generic Collections

        #region List<T>

        List<int> numbers = new List<int> { 10, 20, 30 };
        numbers.Add(40);
        numbers.Insert(1, 15);
        numbers.Remove(20);
        Console.WriteLine("List<T> contents:");
        foreach (var num in numbers)
            Console.WriteLine(num);
        Console.WriteLine();

        #endregion

        #region Dictionary<TKey, TValue>

        Dictionary<string, int> employeeAges = new Dictionary<string, int>
        {
            ["Alice"] = 30,
            ["Bob"] = 25
        };
        employeeAges.Add("Charlie", 28);
        if (employeeAges.TryGetValue("Bob", out int age))
            Console.WriteLine($"Bob is {age} years old.");
        Console.WriteLine("Dictionary<TKey, TValue> contents:");
        foreach (var kvp in employeeAges)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        Console.WriteLine();

        #endregion

        #region HashSet<T>

        HashSet<string> tags = new HashSet<string> { "dev", "csharp", "dotnet" };
        tags.Add("dev"); // Ignored because it's a duplicate
        Console.WriteLine("HashSet<T> contents:");
        foreach (var tag in tags)
            Console.WriteLine(tag);
        Console.WriteLine();

        #endregion

        #region Queue<T>

        Queue<string> printQueue = new Queue<string>();
        printQueue.Enqueue("Document1");
        printQueue.Enqueue("Document2");
        Console.WriteLine($"Queue peek: {printQueue.Peek()}"); // Document1
        Console.WriteLine($"Dequeued: {printQueue.Dequeue()}"); // Document1
        Console.WriteLine("Remaining in Queue:");
        foreach (var doc in printQueue)
            Console.WriteLine(doc);
        Console.WriteLine();

        #endregion

        #region Stack<T>

        Stack<string> operations = new Stack<string>();
        operations.Push("Open file");
        operations.Push("Edit file");
        operations.Push("Save file");
        Console.WriteLine($"Last operation: {operations.Pop()}"); // Save file
        Console.WriteLine("Remaining in Stack:");
        foreach (var op in operations)
            Console.WriteLine(op);
        Console.WriteLine();

        #endregion

        #region SortedList<TKey, TValue>

        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(2, "B");
        sortedList.Add(1, "A");
        sortedList.Add(3, "C");
        Console.WriteLine("SortedList<TKey, TValue> contents:");
        foreach (var kvp in sortedList)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        Console.WriteLine();

        #endregion

        #region SortedDictionary<TKey, TValue>

        SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
        sortedDict[2] = "Two";
        sortedDict[1] = "One";
        sortedDict[3] = "Three";
        Console.WriteLine("SortedDictionary<TKey, TValue> contents:");
        foreach (var kvp in sortedDict)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        Console.WriteLine();

        #endregion

        #endregion

        #region Concurrent Collections

        #region ConcurrentDictionary<TKey, TValue>

        ConcurrentDictionary<string, int> concurrentDict = new ConcurrentDictionary<string, int>();
        concurrentDict.TryAdd("x", 1);
        concurrentDict.TryUpdate("x", 2, 1);
        Console.WriteLine("ConcurrentDictionary<TKey, TValue> contents:");
        foreach (var kvp in concurrentDict)
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        Console.WriteLine();

        #endregion

        #region BlockingCollection<T>

        BlockingCollection<string> taskQueue = new BlockingCollection<string>();
        taskQueue.Add("Task1");
        taskQueue.Add("Task2");
        taskQueue.CompleteAdding();
        Console.WriteLine("BlockingCollection<T> contents:");
        foreach (var task in taskQueue.GetConsumingEnumerable())
            Console.WriteLine(task);

        #endregion

        #endregion
    }
}