namespace Encapsulation;

//tạo lên class tức là ta đang tạo 1 kiểu dữ liệu mới trong chương trình và kiểu dữ liệu này được tích hợp nhiều kiểu dữ liệu mới bên trong
// tính đóng gói là những thông tin thuộc tính của đối tượng và hành vi của nó sẽ được định nghĩa chung với nhau ở 1 class
public class Student
{
    // Attributes(thuộc tính) những thông tin cần lưu trữ trong class

    // phạm vi truy cập:
    // private chỉ truy cập được bên trong class student
    // protected có thẻ truy cập được bên trong class và những class được kế thừa từ class
    // public có thể truy cập được ở bất kì đâu trong hệ thống

    //Attributes ở đây là 1 thuật ngữ chỉ những thuộc tính thật sự lưu tru dữ liệu của đối tượng, tức là biến này lưu tru những giá trị của đối tượng 
    private string studentId;
    private string name;
    private int birthYear;
    private bool gender;
    private string stdClass;

    //Properties giúp ta truy cập được các Attributes ở bên ngoài lớp
    public int BirthYear
    {
        get => birthYear;
        set
        {
            //value là dữ liệu truyền vào
            var year = DateTime.Now.Year;
            if (value > 0 && value <= year) birthYear = value;
            Console.WriteLine("Nhap lai nam sinh");
        }
    }

    public string StudentId
    {
        get => studentId;
        set => studentId = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int BirthYear1
    {
        get => birthYear;
        set => birthYear = value;
    }

    public bool Gender
    {
        get => gender;
        set => gender = value;
    }

    public string StdClass
    {
        get => stdClass;
        set => stdClass = value ?? throw new ArgumentNullException(nameof(value));
    }

    // constructors là phương thức giúp khởi tạo lên 1 đối tượng. 1 class có thể có nhiều constructors mỗi constructors sẽ đại diện cho 1 đối tượng mà ta muốn tryền vào 
    // đây là 1 phương thức không có kiểu trả về, tên của phương thức phải giống với tên class
    // nó sẽ tạo mới 1 đối tượng sinh viên và bên trong có các tham số và nó sẽ lấy các tham số gán vào các thuộc tính tương ứng 
    public Student()
    {
    }

    public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
    {
        //this là phạm vi của biến lớn nhất. Trong đây là class student
        this.studentId = studentId;
        this.name = name;
        this.birthYear = birthYear;
        this.gender = gender;
        this.stdClass = stdClass;
    }


    // Methods

    //đại diện cho phương thức get: lấy giá trị để show
    public int GetBirthYear()
    {
        return birthYear;
    }

    //đại diện cho phương thức set: thiet lập giá trị cho 1 thuộc tính vì thuộc tính đang để private
    public void SetBirthYear(int birth)
    {
        var year = DateTime.Now.Year;
        if (birth > 0 && birth <= year) this.birthYear = birth;
        Console.WriteLine("Nhap lai nam sinh");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"- MSSV: {studentId}");
        Console.WriteLine($"- Ho ten: {name}");
        Console.WriteLine($"- Nam sinh: {birthYear}");
        Console.WriteLine($"- Gioi tính: {gender}");
        Console.WriteLine($"- Lop: {stdClass}");
    }
}