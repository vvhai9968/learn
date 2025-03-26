namespace Abstraction;

class Abstraction
{
    //c# không có khái niệm đa kế thừa

    //abstract nghĩa là 1 class đang dang dở và các lớp con phải kế thừa và thực thi các hàm abstract bên trong nó
    //không được cho abstract đi với sealed vì 2 cái nó trái ngược nhau sealed là hoàn thành rồi ko cho override nữa còn abstract là chưa hoàn thành bắt buộc phải override
    public abstract class Animal
    {
        //protected cho phep lop ke thua được truy cập
        // protected string Name { get; set; }

        // abstract bắt buộc phải thực thi
        // virtual nghĩa gần giống abstract nên 2 cái ko thể đi cùng nhau được: virtual cho phép override ,abstract bắt buộc phải override
        protected abstract string Name { get; set; }

        public abstract void MakeNoise(); //bên trong abstract chi chứa phần định nghĩa của 1 phương thức pần thực thi phải từ lớp con ke thừa từ nó
    }


    // khác với abstract thì interface chỉ là bản thiết kế chi tiết của các method và 1 class có thể kế thừa được nhiều interface
    // hiểu đơn giản là interface giong abstract vì đều là class đang dang dở và các lớp kế thừa nó phải thức thi các hàm bên trong nó
    public interface IRunable

    {
        string Run();
    }

    interface IWorkable

    {
        string Work();
    }

    public class Person : IRunable, IWorkable

    {
        public string Run()
        {
            return "Person runing...";
        }
        
        public string Work()
        {
            return "Person working...";
        }
    }
    

    public class Cat : Animal
    {
        private string name;

        protected override string Name
        {
            get => this.name.ToUpper();
            set => this.name = value;
        }

        public override void MakeNoise() //override nghĩa là tôi sẽ viết lại hàm này
        {
            Console.WriteLine($"{this.Name}: Meo Meo");
        }

        public Cat(string name)
        {
            this.Name = name;
        }

        //không thể định nghĩa 1 abstract nếu class đó không được khai báo la abstract class
        //public  abstract void Eat();
    }

    static void Main(string[] args)
    {
        var a = new Cat("123123");
        a.MakeNoise();

        var b = new Person();
        Console.WriteLine(b.Run());
    }
}