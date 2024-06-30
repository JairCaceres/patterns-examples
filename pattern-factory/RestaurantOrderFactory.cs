using pattern_factory.Interfaces;
using pattern_factory.Models;

namespace pattern_factory
{
    public class RestaurantOrderFactory
    {
        public IOrder CreateOrder(RestaurantEnum restaurantId)
        {
            if (restaurantId == RestaurantEnum.mcdonalds)
            {
                return new McDonaldsOrder();
            }
            else if (restaurantId == RestaurantEnum.mostaza)
            {
                return new MostazaOrder();
            }
            else
            {
                throw new ArgumentException("Restaurant not available");
            }
        }
    }
}