namespace Task;
using System.Threading.Tasks;

public class Program
{
    /// <summary>
    /// ------------------- Advantages -------------------
    /// - async/await support: clean async code without blocking
    /// - return values: task can return results like function
    /// - Exception handing: you can try/catch around await
    /// - Scalable: uses ThreadPool efficiently
    /// -  Continuation support: You can chain task with .ContinueWith();
    /// 
    /// ------------------- Disadvantages -------------------
    /// - overhead: for very tiny task creating a task is heavy
    /// - not real-time: Not good for hard real-time system
    /// - less control than thread: can't set priority, name, ...
    ///
    /// ------------- Automatically uses the ThreadPool -------------
    /// - it doesn't need to create a new thread every time( creating threads is slow and expensive)
    /// - it reuses existing threads
    /// - the system manages how many threads can run at once
    /// - Saves CPU and memory 
    /// </summary>
    static async Task Main()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        Console.WriteLine("Task Time: start");

        var tasks = new Task[100];
        for (int i = 0; i < 100; i++)
        {
            tasks[i] = Task.Run(DoWork);
        }

        await Task.WhenAll(tasks);

        watch.Stop();
        Console.WriteLine($"Task Time: {watch.ElapsedMilliseconds} ms");
    }

    private static void DoWork()
    {
        // Simulate CPU-bound work
        double sum = 0;
        for (int i = 0; i < 100000000; i++)
            sum += Math.Sqrt(i);
    }
}