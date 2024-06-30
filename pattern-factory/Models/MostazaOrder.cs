
namespace pattern_factory.Models
{
    public class MostazaOrder : OrderBase
    {
        public override void Send()
        {
            Console.WriteLine("Sending order to Mostaza...");
        }
    }
}
