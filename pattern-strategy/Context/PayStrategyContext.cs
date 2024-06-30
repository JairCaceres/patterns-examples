using pattern_strategy.Interfaces;

namespace pattern_strategy.Context
{
    public class PayStrategyContext
    {
        private readonly IBehavior _behavior;

        public PayStrategyContext(IBehavior behavior)
        {
            _behavior = behavior;
        }

        public void DoBehavior()
        {
            _behavior.DoBehavior();
        }
    }
}
