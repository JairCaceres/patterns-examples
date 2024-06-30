using pattern_factory.Interfaces;

namespace pattern_factory.Models
{
    public abstract class OrderBase : IOrder
    {
        public void Confirm()
        {
            Console.WriteLine("Confirming order...");
        }

        public void Pay()
        {
            Console.WriteLine("Paying order...");
        }

        public abstract void Send();
    }

}
