namespace StackOverflow;

public class Person
{
    private string _name;

    public string Name
    {
        get { return Name; }   // ❌ This is the problem
        set { Name = value; }  // ❌ And this too
    }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.Name = "John"; // 💥 StackOverflowException
    }
}