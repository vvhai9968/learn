namespace Ref_Out_In;

class Program
{
    /// <summary>
    /// ******************* ref *******************
    /// ------------------- Definition -------------------
    /// ref means the argument is passed by reference, and the variable must be initialized before being passed to the method
    /// 
    /// ------------------- Advantages -------------------
    /// + Allows a method to modify the caller's variable directly
    /// + Can be used to return multiple values form a method 
    /// + Good for passing large structs to avoid copying
    /// 
    /// ------------------- Disadvantages -------------------
    /// + Makes the code harder to read and maintain if overused
    /// + Requires the variable to be initialized before the method call 
    /// + Can lead to unexpected side effects if method changes the value unexpectedly
    ///
    /// -------------------- Use cases --------------------
    /// + Modifying an input value and needing to preserve that change outside the method
    /// + Performance optimization when passing large structures 
    /// + when you want bi-directional data flow (input + output)
    /// 
    ///
    /// 
    /// ******************* out *******************
    /// ------------------- Definition -------------------
    /// out means the argument is passed by reference, but the variable does not need to be initialized before being passed. It must be assigned a value inside the method before the method returns
    ///  
    /// ------------------- Advantages -------------------
    /// + Good for returning multiple values form a method 
    /// + Clear intention: the value is for output only
    /// + Cleaner syntax in some cases (e.g. TryParse methods)
    /// 
    /// ------------------- Disadvantages -------------------
    /// + You can't use the variable before the method call
    /// + Like ref. can lead to code that's harder to understand or maintain
    /// + Needs extra caution to ensure that the variable is assigned inside the method
    /// 
    /// -------------------- Use cases --------------------
    /// + When a method needs to return more than on value (e.g., a success flag and a result)
    /// + Useful when a method is supposed to provide output only, not use any input value
    /// </summary>
    static void Main()
    {
        var myNum = 10;
        AddFive(ref myNum);
        Console.WriteLine(myNum); // Output: 15

        GetUserName(out var userName);
        Console.WriteLine(userName); // Output: Alice

        var i = 1;
        Print(in i);
    }

    static void AddFive(ref int number)
    {
        number += 5;
    }

    static void GetUserName(out string name)
    {
        name = "Alice";
    }

    static void Print(in int s)
    {
        Console.WriteLine(s);
    }
}