namespace Liskov_Substitution_Principle;

public class Program
{
    /// <summary>
    /// L - Liskov Substitution Principle (LSP)
    /// Definition: You should be able to use a subclass in place of a superclass and the app still works correctly
    ///
    /// Why it matters:
    /// + Ensures correct inheritance
    /// + Prevents weird bug when using base class references
    /// </summary>
    ///

    #region Violates LSP

    public class Bird
    {
        public virtual void Fly() => Console.WriteLine("Flying...");
    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new Exception("Ostrich can't fly"); // ❌ Breaks LSP
        }
    }

    // this will cause runtime errors if someone expects all birds to fly

    #endregion

    #region Better Design

    public abstract class Birds
    {
    }

    public interface IFlyingBird
    {
        void Fly();
    }

    public class Sparrow : Birds, IFlyingBird
    {
        public void Fly() => Console.WriteLine("Flying...");
    }

    public class Ostriches : Bird
    {
        // Ostrich doesn't implement Fly
    }
    // now, only birds that can fly implement the flying behavior
    #endregion

    static void Main()
    {
    }
}