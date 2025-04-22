namespace Thread;
using System.Threading;

class Program
{
    /// <summary>
    ///  ---------------------------- Advantages ----------------------------
    ///  + full control:
    ///    set name: t.Name = "WorkerThread"
    ///    set priority: t.Priority = ThreadPriority.AboveNormal
    ///    choose foreground/background: t.IsBackground = true;
    ///  + good for long-running or blocking tasks
    ///  + Parallel execution: great for truly parallel work on multiple cores
    ///  + independent lifecycle: thread will run independent even if others are busy or blocked
    ///
    /// ---------------------------- Disadvantages ----------------------------
    ///  + Expensive to create: threads are heavier than threadPool threads (more memory, CPU time to create)
    ///  + Limited scaling: too many threads = performance issues ( context switching, resource contention)
    ///  + No built-in result or async support: you have to manually implement return values and error handing
    ///  + Manual cleanup & tracking: You must manage when it ends, exceptions, and possibly join it manually: t.Join();
    /// </summary>
    static void Main()
    {
        var thread = new Thread(PrintNumbers);
        var thread2 = new Thread(PrintNumbers2);
        thread.Name = "haivv";
        thread.Start();
        thread2.Start();
            
        Console.WriteLine("Main thread is doing other work...");
        thread.Join(); // Wait for the thread to finish
        Console.WriteLine("Main thread finished.");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(500); // Simulate work
        }
    }
    
    
    static void PrintNumbers2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread2: {i}");
            Thread.Sleep(500); // Simulate work
        }
    }
}