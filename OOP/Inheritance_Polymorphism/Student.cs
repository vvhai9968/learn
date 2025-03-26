namespace Inheritance_Polymorphism;

//kế thừa là thêm dấu : vào sau tên lớp và tiếp theo là tên lớp cơ sở mà lớp này muốn kế thừa
public class Student : Person
{
    //Attributes
    private string program;
    private int year;
     
    //Constructors
    public Student() : base() { }

    //base truy xuất những constructors gì nằm ở trên lớp cơ sở của class Person truy cập với các thuộc tính của person gián tiếp thông qua constructors
    public Student(string name, int birthYear, string address, string program, int year) : base(name, birthYear, address)
    {
        this.program = program;
        this.year = year;
    }
     
    //overriding: ghi đè phương thức là thay đổi nội dung bên trong của phương thức
    public override void Input()
    {
        //gọi phương thức input ở trên lớp cơ sở bằng từ khóa base
        base.Input();
        Console.Write("Nhap nganh hoc: ");
        program = Console.ReadLine();
        Console.Write("SV nam thu: ");
        year = int.Parse(Console.ReadLine());
    }
     
    // mọi object trong c# đều được kế thừa phương thức ToString
    // public override string ToString()
    // {
    //      return base.ToString() + $"[ program: {program}, year: {year}]";
    // }
     
    // thêm từ khóa sealed để đánh dấu đây là lần ghi đè cuối cùng lớp sau kế thừa lại từ lớp này sẽ không ghi đè được
    public sealed override string ToString()
    {
        return base.ToString() + $"[ program: {program}, year: {year}]";
    }
}