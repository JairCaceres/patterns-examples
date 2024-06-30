using pattern_state.Context;
using pattern_state.Interfaces;

namespace pattern_state.States
{
    public class GreenState : ITrafficLightState
    {
        public void StopTraffic()
        {
            Console.WriteLine("Light is red");
        }
        public void WarningTraffic()
        {
            Console.WriteLine("Light is yellow");
        }
        public void ContinueTraffic()
        {
            Console.WriteLine("Light is green");
        }
    }
}
