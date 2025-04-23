namespace Interface_Segregation_Principle;

public class Program
{
    /// <summary>
    /// I - Interface Segregation Principle (ISP)
    /// Definition:
    /// + No client should be forced to depend on methods it does not use
    /// + Split big interfaces into smaller, more specific ones
    ///
    /// why it matters
    /// + avoids unnecessary implementation
    /// + improves code readability and testability
    /// </summary>

    #region Bad Example

    public interface IMachine
    {
        void Print();
        void Scan();
        void Fax();
    }

    public class OldPrinter : IMachine
    {
        public void Print()
        {
        }

        public void Scan()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }
    }
    // OldPrinter is forced to implement methods it doesn't support

    #endregion

    #region Good Example

    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
        }
    }

    #endregion

    static void Main()
    {
    }
}