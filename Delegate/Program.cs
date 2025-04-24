using System.Linq.Expressions;

namespace DelegateDemo
{
    // 1. Custom delegate
    public delegate int MathOperation(int x, int y);

    public class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // 2. Func - Add two numbers
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Add: {add(3, 4)}");  // Output: 7

            // 3. Action - Print all numbers
            Action<List<int>> printList = list =>
            {
                Console.Write("Numbers: ");
                list.ForEach(n => Console.Write(n + " "));
                Console.WriteLine();
            };
            printList(numbers);

            // 4. Predicate - Filter even numbers
            Predicate<int> isEven = x => x % 2 == 0;
            var evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // 5. Lambda Expression with LINQ
            var squaredNumbers = numbers.Select(x => x * x).ToList();
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));

            // 6. Expression Tree (for future translation or analysis)
            Expression<Func<int, bool>> expr = x => x > 3;
            Console.WriteLine($"Expression: {expr}");  // Output: x => (x > 3)

            // 7. Use custom delegate
            MathOperation multiply = (x, y) => x * y;
            Console.WriteLine($"Multiply: {multiply(5, 6)}");  // Output: 30
        }
    }
}