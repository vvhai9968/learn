namespace Single_responsibility_principle;

public class Program
{
    /// <summary>
    /// S - Single responsibility principle (SRP)
    /// Definition: A class should have only one reason to change, meaning it should have only one job or responsibility
    ///
    /// why it matters:
    /// + easy to test, debug and maintain
    /// + reduces side effects when modifying this code
    /// + encourages modular code 
    /// </summary>

    #region Bad Example:

    public class Report
    {
        public void Generate()
        {
            // generate report
        }

        public void SaveToDatabase()
        {
            // DB logic
        }

        public void Print()
        {
            // Print logic
        }
    }
    // this class has 3 responsibilities: report generation, saving, and printing. Changes in any of these could affect the class

    #endregion

    #region Good example

    public class ReportGenerator
    {
        public Report Generate()
        {
            // generate and return report
            return new Report();
        }
    }

    public class ReportSaver
    {
        public void Save(Report report)
        {
            // Save logic
        }
    }

    public class ReportPrinter
    {
        public void Print(Report report)
        {
            // Print logic
        }
    }

    #endregion


    static void Main()
    {
    }
}