namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        // //biến là sv1 và bên trong biến chứa nhiều thông tin. Trong lập trình hướng đối tượng gọi là 1 đối tượng thuộc về 1 lớp nào đó
        // var sv1 = new Student();
        //
        // // có thể truy cập các đối tượng thông qua tên của nó là sv1
        // sv1.studentId = "1231231"; // ko thể sửa khi phạm vi truy cập đang để là private
        // sv1.PrintInfo();
        Console.WriteLine("-------------------------");
        var sv2 = new Student("2121313", "Vũ Văn Hải", 2003, true, "12H");
        // Console.WriteLine(sv2.GetBirthYear());
        // sv2.SetBirthYear(-2);
        sv2.BirthYear = -5;
        sv2.PrintInfo();

    }
}