using pattern_adapter.Interfaces;
using pattern_adapter.Adapter;

namespace pattern_adapter.Client
{
    public class ClientCode
    {
        public void Run(ITargetInterface target)
        {
            Console.WriteLine("Modern data obtained: " + target.GetModernData());
            target.DoSpecificOperation();
        }
    }
}
