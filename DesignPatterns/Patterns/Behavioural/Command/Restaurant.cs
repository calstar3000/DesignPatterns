
namespace DesignPatterns.Patterns.Behavioural.Command
{
    /// <summary>
    /// This class simulates a restaurant with a waiter that can take and cancel
    /// orders until the point they are sent to the kitchen.
    /// </summary>
    public class Restaurant
    {
        public void OpenForBusiness()
        {
            var waiter = new Waiter("Aaron");

            var frenchToast = new OrderOfFrenchToast();
            var pancakes = new OrderOfPancakes();
            var waffles = new OrderOfWaffles();

            waiter.TakeOrder(frenchToast);
            waiter.TakeOrder(pancakes);
            waiter.TakeOrder(waffles);
            waiter.CancelOrder(waffles);

            waiter.PlaceOrders();

            waiter.CancelOrder(pancakes);
        }
    }
}
