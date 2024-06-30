using pattern_adapter.Adapter;
using pattern_adapter.Client;
using pattern_adapter.Legacy;

namespace pattern_adapter
{
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            LegacyClass legacyClass = new LegacyClass();
            AdapterClass adapter = new AdapterClass(legacyClass);

            ClientCode client = new ClientCode();
            client.Run(adapter);

        }
    }
}