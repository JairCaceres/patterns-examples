namespace pattern_observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            PromotionNotifier notifier = new PromotionNotifier();

            Customer customer1 = new Customer("user 1", "user1@gmail.com");
            Customer customer2 = new Customer("user 2", "user2@gmail.com");

            notifier.RegisterObserver(customer1);
            notifier.RegisterObserver(customer2);

            notifier.NewPromotion("50% off on all items!");

            notifier.RemoveObserver(customer1);

            notifier.NewPromotion("Buy one get one free!");

            Console.ReadKey();
        }
    }
}