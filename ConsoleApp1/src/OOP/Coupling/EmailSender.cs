
namespace ConsoleApp1.src.OOP.Coupling{
    public class EmailSender : INotificationService{
        public void SendNotification(string message){
            Console.WriteLine("Sending email: "+message);
        }
    }
}