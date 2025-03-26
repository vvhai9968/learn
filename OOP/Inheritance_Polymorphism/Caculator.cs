namespace Inheritance_Polymorphism;

public class Caculator
{
    //Overloading methods là nạp chồng các phương thức tức là các phương thức sẽ cùng có 1 tên khác tham số chuyền vào
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}