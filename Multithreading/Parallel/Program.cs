namespace Parallel;
using System.Diagnostics;
using System.Threading.Tasks;

public class Program
{
    /// <summary>
    /// 
    ///  ---------------------------- Introduce ----------------------------
    /// Parallel is part of the Task Parallel Library (TPL). It helps you run loops in parallel, using multiple cores automatically.
    /// Instead of doing things one-by-one, Parallel splits work into multiple tasks, runs them concurrently, and waits for all to finish.
    ///
    ///  ---------------------------- Advantages ----------------------------
    /// 🚀 Fast on large data:	Runs iterations concurrently → better speed
    /// 🧠 Automatic threading:	No need to manage threads manually
    /// 🔧 Easy to use:	Just replace for with Parallel.For
    /// ⚙️ Uses ThreadPool:	Efficient — no need for custom thread creation
    /// 
    /// ---------------------------- Disadvantages ----------------------------
    /// ❌ Not for small work: May be slower due to thread overhead
    /// ❌ Hard to control order: Tasks run in random order (not sequential)
    /// ❌ Not good with shared data: Needs locking to avoid race conditions
    /// ❌ No async/await: Can't use await inside Parallel.For
    ///
    /// 💡 When should you use it?
    /// Use Parallel when:
    /// - You have a CPU-heavy task (e.g., calculations, image processing)
    /// - Each iteration is independent (no need to share data)
    /// - You want to speed up loops using multiple cores
    ///
    ///⚠️ Don’t use when:
    /// - You're doing I/O operations (e.g., database, file, API calls) → use async/await instead.
    /// - Order matters
    /// - You need to await inside the loop
    /// </summary>
    static void Main()
    {
        var watch = Stopwatch.StartNew();
        Console.WriteLine("Parallel Time: start");

        Parallel.For(0, 100, i => { DoWork(); });

        watch.Stop();
        Console.WriteLine($"Parallel Time: {watch.ElapsedMilliseconds} ms");
    }

    private static void DoWork()
    {
        double sum = 0;
        for (var i = 0; i < 100000000; i++)
            sum += Math.Sqrt(i);
    }
}