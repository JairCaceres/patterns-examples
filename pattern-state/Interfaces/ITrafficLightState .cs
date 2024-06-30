using pattern_state.Context;

namespace pattern_state.Interfaces
{
    internal interface ITrafficLightState
    {
        void StopTraffic();
        void WarningTraffic();

        void ContinueTraffic();

    }
}
