
namespace pattern_factory.Models
{
    public class McDonaldsOrder : OrderBase
    {
        public override void Send()
        {
            Console.WriteLine("Sending order to McDonalds...");
        }
    }
}
