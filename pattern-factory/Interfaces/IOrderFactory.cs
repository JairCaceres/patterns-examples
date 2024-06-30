namespace pattern_factory.Interfaces
{
    public interface IOrderFactory
    {
        IOrder CreateOrder(string restaurantName);
    }
}
