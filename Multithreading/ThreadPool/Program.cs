namespace ThreadPool;
using System.Threading;

class Program
{ 
    /// <summary>
    /// a threadPool is a collection of pre-instantiated, reusable threads that can be used to perform multiple tasks in the background.
    /// Instead of creating and destroying threads every time a task is needed the system maintains a pool of threads to reduce overhead and improve performance
    ///--------------------
    /// Limit:
    /// If the main thread ends before the threadPool task finishes, then:
    /// + The threadPool thread is abruptly stopped( because it's a background thread )
    /// + any code after that point won't run
    /// + it can lose data, skip logs, or miss saving results depending on what the task was doing
    /// ---> solusion: use Task with await or some synchronization to ensure your task completes safely 
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Main thread is continuing...");
        ThreadPool.QueueUserWorkItem(PrintNumbers);
        Thread.Sleep(3000); // Wait so we can see output
        Console.WriteLine("Main thread is end...");
    }

    static void PrintNumbers(object state)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"ThreadPool thread: {i}");
            Thread.Sleep(500);
        }
    }
}