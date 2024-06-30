using pattern_factory.Interfaces;

namespace pattern_factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            RestaurantOrderFactory factory = new RestaurantOrderFactory();

            RestaurantEnum restaurantId = RestaurantEnum.mostaza;

            IOrder order = factory.CreateOrder(restaurantId);

            order.Confirm();
            order.Pay();
            order.Send();
        }
    }
}