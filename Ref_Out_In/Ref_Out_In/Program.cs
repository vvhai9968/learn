namespace Ref_Out_In
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ChangeValueRef(ref a);
            ChangeValueOut(out var b);
            ChangeValueIn(a);
            Console.WriteLine(a);
        }

        static bool ChangeValueRef(ref int x)
        {
            x = 20;
            return true;
        }
        
        static bool ChangeValueOut(out int x)
        {
            x = 20;
            return true;
        }
        
        static bool ChangeValueIn(in int x)
        {
            return true;
        }
    }
}