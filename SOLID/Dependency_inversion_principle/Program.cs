namespace Dependency_inversion_principle;

public class Program
{
    /// <summary>
    /// D - Dependency Inversion Principle (DIP)
    /// 
    /// Definition:
    /// + High-level modules should not depend on low-level modules
    /// + Both should depend on abstractions (interface)
    ///
    /// Why it matters:
    /// + Encourages loosely coupled code
    /// + Makes code more testable and flexible
    /// </summary>

    #region Bad Example

    public class EmailSender
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class NotificationService
    {
        private EmailSender _sender = new EmailSender();
        public void Notify(string message) => _sender.SendEmail(message);
    }
    // NotificationService is tightly coupled to EmailService

    #endregion

    #region Good Example

    public interface IMessageSender
    {
        void Send(string message);
    }

    public class EmailSenders : IMessageSender
    {
        public void Send(string message) => Console.WriteLine($"Email: {message}");
    }

    public class SmsSender : IMessageSender
    {
        public void Send(string message) => Console.WriteLine($"SMS: {message}");
    }

    public class NotificationServices
    {
        private readonly IMessageSender _sender;

        public NotificationServices(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Notify(string message) => _sender.Send(message);
    }

    #endregion

    static void Main()
    {
    }
}