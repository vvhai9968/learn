namespace Scope
{
    public class AssemblyBaseClass
    {
        private string PrivateVar = "private";
        protected string ProtectedVar = "protected";
        internal string InternalVar = "internal";
        protected internal string ProtectedInternalVar = "protected internal";
        public string PublicVar = "public";

        public void TestAccess()
        {
            //Accessible
            Console.WriteLine(PrivateVar);
            Console.WriteLine(ProtectedVar);
            Console.WriteLine(InternalVar);
            Console.WriteLine(ProtectedInternalVar);
            Console.WriteLine(PublicVar);
        }
        
    }

    public class AssemblyDerivedClass : AssemblyBaseClass
    {
        public void TestAccessDerivedClass()
        {
            //Not Accessible
            //Console.WriteLine(PrivateVar);
            
            //Accessible
            Console.WriteLine(ProtectedVar);
            Console.WriteLine(InternalVar);
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
            
            //Accessible
            Console.WriteLine(objBase.InternalVar);
            Console.WriteLine(objBase.ProtectedInternalVar);
            Console.WriteLine(objBase.PublicVar);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var objBase = new AssemblyBaseClass();
            objBase.TestAccess();
            Console.WriteLine("----------------------------");
            var objDerived = new AssemblyDerivedClass();
            objDerived.TestAccessDerivedClass();
            Console.WriteLine("----------------------------");
            var objOtherBase = new AssemblyOtherClass();
            objOtherBase.TestAccess();
        }
    }
}