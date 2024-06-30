using pattern_state.Enum;
using pattern_state.Interfaces;
using pattern_state.States;

namespace pattern_state.Context
{
    public class TrafficLight
    {
        private ITrafficLightState currentState { get; set; }
        private StateEnum step { get; set; }
        private StateEnum previusStep { get; set; }

        public TrafficLight()
        {
            currentState = new RedState();
            step = StateEnum.red;
            previusStep = StateEnum.red;

        }

        public void StopTraffic()
        {
            currentState.StopTraffic();

            if(step == StateEnum.red)
            {
                step = StateEnum.yellow;
                currentState = new YellowState();
            }

        }

        public void WarningTraffic()
        {
            currentState.WarningTraffic();
            if(step == StateEnum.yellow)
            {
                step = previusStep == StateEnum.red ? StateEnum.green : StateEnum.red;
                currentState = previusStep == StateEnum.red ? new GreenState() : new RedState();
            }

        }

        public void ContinueTraffic()
        {
            currentState.ContinueTraffic();

            if(step == StateEnum.yellow)
            {
                step = StateEnum.yellow;
                previusStep = StateEnum.green;
                currentState = new YellowState();
            }

        }
    }
}
