using Scope;

namespace Assembly2
{
    public class AssemblyDerivedClass : AssemblyBaseClass
    {
        public void TestAccessDerivedClass()
        {
            //Not Accessible
            //Console.WriteLine(PrivateVar);
            //Console.WriteLine(InternalVar);
            
            //Accessible
            Console.WriteLine(ProtectedVar);
            
            Console.WriteLine(ProtectedInternalVar);
            Console.WriteLine(PublicVar);
        }
    }
    
    public class AssemblyOtherClass
    {
        public void TestAccess()
        {
            var objBase = new AssemblyBaseClass();
            //Not Accessible
            // Console.WriteLine(objBase.PrivateVar);
            // Console.WriteLine(objBase.ProtectedVar);
            //Console.WriteLine(objBase.InternalVar);
            //Console.WriteLine(objBase.ProtectedInternalVar);
            
            //Accessible
            Console.WriteLine(objBase.PublicVar);
        }
    }
    
    class Program
    {
        static void Main(string[] arg)
        {
            var objDerived = new AssemblyDerivedClass();
            objDerived.TestAccessDerivedClass();
            objDerived.TestAccess();
            Console.WriteLine("----------------------------");
            var objOther = new AssemblyOtherClass();
            objOther.TestAccess();
        }
    }
}