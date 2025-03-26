namespace Inheritance_Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        // var p = new Person();
        // p.Input();
        // Console.WriteLine(p.ToString());
        //
        // //student đã kế thừ từ person nên có phương thức Input()
        // var st = new Student();
        // st.Input();
        // Console.WriteLine(st.ToString());
        
        
        // Overloading 
        var cal = new Caculator();
        int sum1 = cal.Add(1, 2);
        int sum2 = cal.Add(1, 2,3);
        double sum3 = cal.Add(1.9, 2.9);
        
    }
    
    // overriding khi muốn định nghĩa các phương thức cùng tên cùng tham số nhưng thực hiện các công việc khác nhau 
    // overloading khi muons định nghĩa các phương thức cùng tên nhưng khác nhau về số lượng hoặc kiểu dữ liệu các tham số
}

//operator overloading 
// Cú pháp: sử dung từ  khóa "operator"
// Båt buộc dùng từ khóa public vå static
// Néu là toán tử 1 ngôi (++, —, !, ...) thi can 1 tham sd.
// Néu là toán tử 2 nôi (+, -, *, /,...)can 2 tham Sö
// Trong tham sö, phải có it nhất 1 tham số thuộc kiểu dữ liệu đang dinh nghĩa operator
// public static <return-type> operator <operator-sign> (parameters){}

// ex:
// Fraction f1 = new Fraction(3,4)
// Fraction f2 = new Fraction(3,4)
// Fraction sum2 = f1 + f2

// public static Fraction operator + (Fraction f 1, Fraction f2){
// int num = fl.numerator * f2.denominator + fl.denominator * f2.numerator;
// int demo = fl.denominator * f2.denominator,
// return new Fraction(num, demo);}

// public static bool operator == (Fraction f1, Fraction f2){
// int num f1 = f1.numerator * f2.denominator;
// int num f2 = f2.numerator * f1.denominator;
// return (num_f1 == num f2);}