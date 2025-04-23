namespace Open_closed_principle;

public class Program
{
    /// <summary>
    /// O - Open/Closed Principle (OCP)
    ///
    /// Definition:
    /// + Software should be open for extension but closed for modification
    /// + You should be able to add new behavior without changing existing code  
    ///
    /// Why it matters:
    /// + Adding new functionality doesn't break existing behavior
    /// + encourages usage of abstraction and polymorphism 
    /// </summary>
    /// 

    #region Bad Example

    public class DiscountCalculator
    {
        public double GetDiscount(string customerType)
        {
            if (customerType == "Regular") return 0.1;
            if (customerType == "VIP") return 0.2;
            return 0;
        }
    }
    // Every time a new customer type is added you must modify this method --- that breaks OCP

    #endregion

    #region Good example

    public interface IDiscountStrategy
    {
        double GetDiscount();
    }

    public class RegularCustomer : IDiscountStrategy
    {
        public double GetDiscount() => 0.1;
    }

    public class VIPCustomer : IDiscountStrategy
    {
        public double GetDiscount() => 0.2;
    }

    public class DiscountCalculatorg
    {
        public double CalculateDiscount(IDiscountStrategy strategy)
        {
            return strategy.GetDiscount();
        }
    }
    // now you can add new types (like GoldCustomer) without touching existing logic

    #endregion


    static void Main()
    {
    }
}