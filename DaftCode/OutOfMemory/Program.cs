using System.Text;

namespace OutOfMemory;

public class Program
{
    static void Main(string[] args)
    {
        var stringBuilder = new StringBuilder(17, 17);
        stringBuilder.Append("Welcome to the ");
        try
        {
            stringBuilder.Insert(0, "world of C# programming", 1);
            Console.WriteLine(stringBuilder.ToString());
            Console.ReadLine();
        }
        catch (OutOfMemoryException exception)
        {
            Console.WriteLine(exception.Message);
            Console.ReadLine();
        }
    }
}