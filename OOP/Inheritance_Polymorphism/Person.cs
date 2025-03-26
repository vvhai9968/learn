namespace Inheritance_Polymorphism;

public class Person
{
    //Attributes
    private string name;
    private int birthYear;
    private string address;
    
    //Constructors
    public Person()
    {
    }

    public Person(string name, int birthYear, string address)
    {
        this.name = name;
        this.birthYear = birthYear;
        this.address = address;
    }
    
    // //Methods
    // public void Input()
    // {
    //     Console.Write("Nhap ho ten: ");
    //     name = Console.ReadLine();
    //     Console.Write("Nhap nam sinh: ");
    //     birthYear = int.Parse(Console.ReadLine() ?? string.Empty);
    //     Console.Write("Nhap đia chi: ");
    //     address = Console.ReadLine();
    // }
    
    //Methods
    // Overriding ở lớp cơ sở muốn xác định đây là 1 phương thức mà ở lớp dẫn suất có thể ghi đè được thì ta thêm từ khóa virtual
    //và lớp dẫn suất muốn ghi đè được thì thêm từ khóa override
    public virtual void Input()
    {
        Console.Write("Nhap ho ten: ");
        name = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        birthYear = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Nhap đia chi: ");
        address = Console.ReadLine();
    }

    public int GetAge()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - birthYear;
    }

    public override string ToString()
    {
        return $"Person[ Name: {name}, Birth: {birthYear}, Address: {address} ]";
    }
}