using pattern_strategy.Context;
using pattern_strategy.Strategy;

namespace pattern_strategy
{
    public class Program
    {
        protected Program() { }
        public static void Main()
        {
            PayByCreditCardBehavior payByCreditCardBehavior = new PayByCreditCardBehavior();
            PayByDebitCardBehavior payByDebitCardBehavior = new PayByDebitCardBehavior();

            PayStrategyContext creditCard = new PayStrategyContext(payByCreditCardBehavior);
            PayStrategyContext debitCard = new PayStrategyContext(payByDebitCardBehavior);

            creditCard.DoBehavior();
            debitCard.DoBehavior();

        }
    }
}