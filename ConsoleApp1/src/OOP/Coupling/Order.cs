namespace ConsoleApp1.src.OOP.Coupling
{
  public class Order
  {
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
      this.notificationService = notificationService;
    }

    public void PlaceOrder()
    {
      // Place order logic
      // ...

      // Send email notification
      notificationService.SendNotification("Order placed successfully");
    }
  }
}